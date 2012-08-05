// Copyright (c) 2012, Lea Hayes
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are met: 
// 
// 1. Redistributions of source code must retain the above copyright notice, this
//    list of conditions and the following disclaimer. 
// 2. Redistributions in binary form must reproduce the above copyright notice,
//    this list of conditions and the following disclaimer in the documentation
//    and/or other materials provided with the distribution. 
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
// WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR
// ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
// (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
// LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
// 
// The views and conclusions contained in the software and documentation are those
// of the authors and should not be interpreted as representing official policies, 
// either expressed or implied, of the FreeBSD Project.

using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using GUIDGenerator.Properties;

namespace GUIDGenerator {

	public partial class GuidGeneratorForm : Form {

		#region Hotkey Management

		[DllImport("user32.dll")]
		private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
		[DllImport("user32.dll")]
		private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

		// Ref: http://msdn.microsoft.com/en-us/library/windows/desktop/ms646309(v=vs.85).aspx
		public const int MOD_ALT = 0x0001;
		public const int MOD_CTRL = 0x0002;
		public const int MOD_SHIFT = 0x0004;

		public const int WM_HOTKEY = 0x0312;

		private const int Hotkey_ID_Ctrl_Shift_V = 1;

		#endregion

		/// <summary>
		/// Last GUID that was generated.
		/// </summary>
		private Guid _lastGuid;

		#region Construction

		/// <summary>
		/// Initialize form.
		/// </summary>
		public GuidGeneratorForm() {
			InitializeComponent();
		}

		#endregion

		#region Events and Messages
		
		private void GuidGeneratorForm_Load(object sender, EventArgs e) {
			// Register system hotkey Ctrl+Shift+V
			RegisterHotKey(Handle, Hotkey_ID_Ctrl_Shift_V, MOD_CTRL | MOD_SHIFT, (int)Keys.V);

			// Prepare initial state of controls
			txtPrefix.Text = Settings.Default.GuidPrefix;
			chkUpperCase.Checked = Settings.Default.UpperCase;
			chkRemoveGUIDHyphens.Checked = Settings.Default.RemoveHyphens;
		}

		private void GuidGeneratorForm_FormClosing(object sender, FormClosingEventArgs e) {
			// Update configuration
			Settings.Default.GuidPrefix = txtPrefix.Text;
			Settings.Default.UpperCase = chkUpperCase.Checked;
			Settings.Default.RemoveHyphens = chkRemoveGUIDHyphens.Checked;
			Settings.Default.Save();

			// Unregister system hotkey Ctrl+Shift+V again
			UnregisterHotKey(Handle, Hotkey_ID_Ctrl_Shift_V);
		}

		protected override void WndProc(ref Message m) {
			// If system hotkey Ctrl+Shift+V was pressed then...
			if (m.Msg == WM_HOTKEY) {
				// Generate new GUID and copy to clipboard
				GenerateGUIDAndCopy();
				// Send Ctrl+V message to active window
				SendKeys.Send("^{v}");
			}

			base.WndProc(ref m);
		}

		private void btnGenerate_Click(object sender, EventArgs e) {
			GenerateGUID();
		}

		private void btnGenerateAndCopy_Click(object sender, EventArgs e) {
			GenerateGUIDAndCopy();
		}

		private void chkUpperCase_CheckedChanged(object sender, EventArgs e) {
			RefreshGUID();
		}

		private void chkRemoveGUIDHyphens_CheckedChanged(object sender, EventArgs e) {
			RefreshGUID();
		}

		private void GuidGeneratorForm_VisibleChanged(object sender, EventArgs e) {
			notifyIcon1.Visible = !Visible;
		}

		private void GuidGeneratorForm_Resize(object sender, EventArgs e) {
			if (WindowState == FormWindowState.Minimized)
				Hide();
		}

		private void notifyIcon1_MouseClick(object sender, MouseEventArgs e) {
			if (e.Button == System.Windows.Forms.MouseButtons.Left) {
				Show();
				WindowState = FormWindowState.Normal;
			}
		}

		private void showToolStripMenuItem_Click(object sender, EventArgs e) {
			Show();
			WindowState = FormWindowState.Normal;
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		#endregion

		#region Methods

		private void RefreshGUID() {
			string guid = _lastGuid.ToString();

			if (chkRemoveGUIDHyphens.Checked)
				guid = guid.Replace("-", "");

			if (chkUpperCase.Checked)
				guid = guid.ToUpper();

			txtUID.Text = txtPrefix.Text + guid;
		}

		private void GenerateGUID() {
			_lastGuid = Guid.NewGuid();
			RefreshGUID();
		}

		private void GenerateGUIDAndCopy() {
			GenerateGUID();
			Clipboard.SetText(txtUID.Text);
		}

		#endregion

	}

}

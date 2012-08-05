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

namespace GUIDGenerator {
	partial class GuidGeneratorForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuidGeneratorForm));
			this.label1 = new System.Windows.Forms.Label();
			this.txtUID = new System.Windows.Forms.TextBox();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.btnGenerateAndCopy = new System.Windows.Forms.Button();
			this.chkUpperCase = new System.Windows.Forms.CheckBox();
			this.chkRemoveGUIDHyphens = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPrefix = new System.Windows.Forms.TextBox();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "UID:";
			// 
			// txtUID
			// 
			this.txtUID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtUID.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUID.Location = new System.Drawing.Point(12, 75);
			this.txtUID.Name = "txtUID";
			this.txtUID.ReadOnly = true;
			this.txtUID.Size = new System.Drawing.Size(453, 30);
			this.txtUID.TabIndex = 3;
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(199, 124);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(100, 35);
			this.btnGenerate.TabIndex = 4;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// btnGenerateAndCopy
			// 
			this.btnGenerateAndCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGenerateAndCopy.Location = new System.Drawing.Point(314, 124);
			this.btnGenerateAndCopy.Name = "btnGenerateAndCopy";
			this.btnGenerateAndCopy.Size = new System.Drawing.Size(151, 35);
			this.btnGenerateAndCopy.TabIndex = 5;
			this.btnGenerateAndCopy.Text = "Generate and Copy";
			this.btnGenerateAndCopy.UseVisualStyleBackColor = true;
			this.btnGenerateAndCopy.Click += new System.EventHandler(this.btnGenerateAndCopy_Click);
			// 
			// chkUpperCase
			// 
			this.chkUpperCase.AutoSize = true;
			this.chkUpperCase.Location = new System.Drawing.Point(324, 35);
			this.chkUpperCase.Name = "chkUpperCase";
			this.chkUpperCase.Size = new System.Drawing.Size(82, 17);
			this.chkUpperCase.TabIndex = 6;
			this.chkUpperCase.Text = "Upper Case";
			this.chkUpperCase.UseVisualStyleBackColor = true;
			this.chkUpperCase.CheckedChanged += new System.EventHandler(this.chkUpperCase_CheckedChanged);
			// 
			// chkRemoveGUIDHyphens
			// 
			this.chkRemoveGUIDHyphens.AutoSize = true;
			this.chkRemoveGUIDHyphens.Location = new System.Drawing.Point(324, 12);
			this.chkRemoveGUIDHyphens.Name = "chkRemoveGUIDHyphens";
			this.chkRemoveGUIDHyphens.Size = new System.Drawing.Size(141, 17);
			this.chkRemoveGUIDHyphens.TabIndex = 6;
			this.chkRemoveGUIDHyphens.Text = "Remove GUID Hyphens";
			this.chkRemoveGUIDHyphens.UseVisualStyleBackColor = true;
			this.chkRemoveGUIDHyphens.CheckedChanged += new System.EventHandler(this.chkRemoveGUIDHyphens_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Prefix:";
			// 
			// txtPrefix
			// 
			this.txtPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtPrefix.Location = new System.Drawing.Point(12, 22);
			this.txtPrefix.Name = "txtPrefix";
			this.txtPrefix.Size = new System.Drawing.Size(287, 20);
			this.txtPrefix.TabIndex = 3;
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "GUID Generator";
			this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(115, 48);
			// 
			// showToolStripMenuItem
			// 
			this.showToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.showToolStripMenuItem.Name = "showToolStripMenuItem";
			this.showToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.showToolStripMenuItem.Text = "&Show...";
			this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// GuidGeneratorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(480, 174);
			this.Controls.Add(this.chkRemoveGUIDHyphens);
			this.Controls.Add(this.chkUpperCase);
			this.Controls.Add(this.btnGenerateAndCopy);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.txtPrefix);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtUID);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "GuidGeneratorForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GUID Generator";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GuidGeneratorForm_FormClosing);
			this.Load += new System.EventHandler(this.GuidGeneratorForm_Load);
			this.VisibleChanged += new System.EventHandler(this.GuidGeneratorForm_VisibleChanged);
			this.Resize += new System.EventHandler(this.GuidGeneratorForm_Resize);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUID;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Button btnGenerateAndCopy;
		private System.Windows.Forms.CheckBox chkUpperCase;
		private System.Windows.Forms.CheckBox chkRemoveGUIDHyphens;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPrefix;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
	}
}


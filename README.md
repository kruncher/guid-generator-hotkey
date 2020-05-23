# guid-generator-hotkey

Quickly paste GUIDs into various applications using hotkey Ctrl+Shift+V


## Getting Started

Download and build project using Microsoft Visual Studio 2010. Works with Microsoft Visual C#
Express Edition.


## How it Works

When application is running Ctrl + Shift + V will generate a new GUID, copy it to the clipboard, and
send the key sequence Ctrl + V to the active application using `SendKeys`.

Previously generated GUID can be pasted as many times as you like (until you copy something to the
clipboard, or generate a new GUID).

Application even works when minimised.


## Why did I create this tool?

I began writing some user documentation using DITA where each topic must have a unique ID. GUIDs
are fairly useful in this scenario so I decided to create this little utility to make life easier.

After a while you forget this utility is even open, in fact I found myself wondering why it was
not working after a reboot... doh! must run first...

I thought that others might find this tool useful, so here it is!


## Options

There are several options:

- Prefix :: Add prefix at start of GUID.
- Remove GUID Hyphens :: When checked removes all hyphens from generated GUID.
- Upper Case :: When checked converts GUID to upper case characters.


## License

Copyright (c) 2012, Lea Hayes
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met: 

1. Redistributions of source code must retain the above copyright notice, this
   list of conditions and the following disclaimer. 
2. Redistributions in binary form must reproduce the above copyright notice,
   this list of conditions and the following disclaimer in the documentation
   and/or other materials provided with the distribution. 

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR
ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

The views and conclusions contained in the software and documentation are those
of the authors and should not be interpreted as representing official policies, 
either expressed or implied, of the FreeBSD Project.

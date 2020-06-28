# fUAC (f**k User Account Control) ![Downloads](https://img.shields.io/github/downloads/tryallthethings/fUAC/total.svg?style=flat) [![Latest Release](https://img.shields.io/github/v/release/tryallthethings/fUAC.svg?logo=github)](https://github.com/tryallthethings/fUAC/releases)

**PLEASE READ: Before continuing to download / use this tool please be aware of the implied security risk. Disabling UAC might bring some convenience but also brings several security risks. Use this tool at your own risk or contact your local Administrator / IT-Support first!**

## Download
Latest version can be downloaded from here: [https://github.com/tryallthethings/fUAC/releases](https://github.com/tryallthethings/fUAC/releases)

## Purpose
This executable will completely disable Windows UAC (User Account Control) [https://en.wikipedia.org/wiki/User_Account_Control](https://en.wikipedia.org/wiki/User_Account_Control). It was created out of the need to circumvent an IT security policy on our test machines which required UAC to be enabled. But UAC broke some of our development software.
If you are in a similar situation you can use this as well.

## Usage
### GUI
Start the executable and click the button in the bottom right corner
### Command-line / batch / Task scheduler
Run `fuac.exe fo`. This will disable UAC and exit the tool immediately.

**For both cases I recommend running the executable as Administrator or command prompt / power shell as their elevated versions. The executable does try to get elevated permissions but does sometimes fail.**

## Supported OS
Tested successfully on Windows 7, 8.1 and 10.

## Virustotal
Check of latest release: [https://www.virustotal.com/gui/file/156c74607370a426ef062ca409d8ce8000b08be7ec50a46232d7406cacd94056](https://www.virustotal.com/gui/file/156c74607370a426ef062ca409d8ce8000b08be7ec50a46232d7406cacd94056)

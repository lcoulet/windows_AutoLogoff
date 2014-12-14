# AutoLogOff utility


## Purpose

It took ages for me to find a configurable simple tool that could be used to log off remote or local sessions whether the machine was a Windows server or a Windows workstation.

I found some tools such as [screensaver operations ](http://www.grimadmin.com/filemgmt/index.php?id=7) or another auto logout tools... I also considered using scheduled tasks, but none of them did the very simple thing I needed.

It took just a dozen lines of codes to build the tool.

Cherry on the ice cream, a window tells the user that she will be logged out automatically after X minuted of no activity, with a timer showing the current number of seconds idle.

## How to use it


Place the software into startup folder of all users start menu.
The sofwtare is 32-bits, but works also on 64-bit systems.

By default the delay is to log off user after 30 minutes Idle time.
The setting can be override by creating a system environment variables named `AUTOLOGOFF_NB_IDLE_MINUTES` 


Tested on Windows 7 and Windows Server 2012 R2.


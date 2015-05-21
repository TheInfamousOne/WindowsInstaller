# WindowsInstaller
Grabs all the installed software on a machine ins 3 seconds or less.  I built this because it was faster than using WMI. 
I developed this program because querying WMI through PowerShell was returning the inforation on the WIN32_PRODUCT class very 
slow.  Sometimes it would take 1  to 4 mintues to return results. 

This was obviously slow.

I'm leveraging a Microsoft.Deployment.WindowsInstaller.dll as a library with the WindowsInstaller.exe

Please drop this in the root directory of ZapIt to work. 

(Both WindowsInstaller.exe and Microsoft.Deployment.WindowsInstaller.dll)


Ty Stallard |
University of Michigan |
MCIT-DES-EDEM |
tyrones@med.umich.edu |
tystallard@gmail.com |
Published on GITHUB ON 05/21/2015 |
Developed on 02/18/2015


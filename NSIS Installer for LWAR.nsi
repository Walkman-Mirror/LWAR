; LWAR Installer NSIS Script
; get NSIS at http://tenet.dl.sourceforge.net/project/nsis/NSIS%202/2.46/nsis-2.46-setup.exe
; As a program that all Power PC users should have, Notepad ++ is recommended to edit this file

AddBrandingImage top 20
Icon "LWAR\Resources\1400410576_24736.ico"
Caption "LWAR Installer"
Name "LWAR"
AutoCloseWindow true
ShowInstDetails show

InstallDir $PROGRAMFILES\DeavmiOSS

OutFile "LWAR\bin\Release\LWAR-Installer.exe"

; Pages

Page components
Page directory
Page instfiles
UninstPage uninstConfirm
UninstPage instfiles

; Sections

Section "LWAR Executable & Uninstaller"
  SectionIn RO
  SetOutPath $INSTDIR
  File "LWAR\bin\Release\LWAR.exe"
  WriteUninstaller "LWAR-Uninst.exe"
SectionEnd

Section "LWAR Start Menu Shortcuts"
  CreateDirectory "$SMPROGRAMS\DeavmiOSS"
  CreateShortCut "$SMPROGRAMS\DeavmiOSS\LWAR.lnk" "$INSTDIR\LWAR.exe" "" "$INSTDIR\LWAR.exe" "" "" "" "Start Launch With Admin Rights (LWAR)"
  CreateShortCut "$SMPROGRAMS\DeavmiOSS\Uninstall LWAR.lnk" "$INSTDIR\LWAR-Uninst.exe" "" "" "" "" "" "Uninstall Launch With Admin Rights (LWAR)"
; Syntax for CreateShortCut: link.lnk target.file [parameters [icon.file [icon_index_number [start_options [keyboard_shortcut [description]]]]]]
SectionEnd

Section "LWAR Desktop Shortcut"
  CreateShortCut "$DESKTOP\LWAR.lnk" "$INSTDIR\LWAR.exe" "" "$INSTDIR\LWAR.exe" "" "" "" "Launch With Admin Rights (LWAR)"
SectionEnd

Section "LWAR Quick Launch Shortcut"
  CreateShortCut "$QUICKLAUNCH\LWAR.lnk" "$INSTDIR\LWAR.exe" "" "$INSTDIR\LWAR.exe" "" "" "" "Launch With Admin Rights (LWAR)"
SectionEnd

;Section "More apps from DeavmiOSS"
; this should have sub options for available apps, that are downloaded
;SectionEnd

; Uninstaller

Section "Uninstall"
  Delete $INSTDIR\LWAR-Uninst.exe   ; Remove Application Files
  Delete $INSTDIR\LWAR.exe
  RMDir $INSTDIR
  
  Delete $SMPROGRAMS\DeavmiOSS\LWAR.lnk   ; Remove Start Menu Shortcuts & Folder
  Delete "$SMPROGRAMS\DeavmiOSS\Uninstall LWAR.lnk"
  RMDir $SMPROGRAMS\DeavmiOSS
  
  Delete $DESKTOP\LWAR.lnk   ; Remove Desktop Shortcut
  Delete $QUICKLAUNCH\LWAR.lnk   ; Remove Quick Launch shortcut
SectionEnd

; Functions

Function .onInit
  MessageBox MB_YESNO "This will install LWAR. Do you wish to continue?" IDYES gogogo
    Abort
  gogogo:
  SetBrandingImage "[/RESIZETOFIT] LWAR\Resources\1400410576_24736.ico"
  SetShellVarContext all
  SetAutoClose true
FunctionEnd

Function .onInstSuccess
  MessageBox MB_YESNO "Install Succeeded! Open Wiki?" IDNO NoReadme
    ExecShell "open" "https://github.com/CampusTools/LWAR/wiki"
  NoReadme:
FunctionEnd

; Uninstaller

Function un.onInit
  MessageBox MB_YESNO "This will uninstall LWAR. Do you wish to continue?" IDYES NoAbort
    Abort ; causes uninstaller to quit.
  NoAbort:
  SetShellVarContext all
  SetAutoClose true
FunctionEnd

Function un.onUninstFailed
  MessageBox MB_OK "Uninstall Cancelled"
FunctionEnd

Function un.onUninstSuccess
  MessageBox MB_OK "Uninstall Completed"
FunctionEnd

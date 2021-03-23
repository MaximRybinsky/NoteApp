#define MyAppName "NoteApp"
#define MyAppVersion "1.0.0"
#define MyAppPublisher "RybinskyMaxim, Inc."
#define MyAppURL "https://github.com/MaximRybinsky/NoteApp"
#define MyAppExeName "NoteAppUI.exe"

[Setup]
AppId={{010D2B03-2FBC-46CB-B133-C1182A232766}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
ChangesAssociations=yes
DisableProgramGroupPage=yes
OutputBaseFilename=NoteAppSetup
SetupIconFile="..\NoteAppUI\Resources\icon.ico"
OutputDir="Installers"
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "Release\NoteAppUI.exe"; DestDir: "{app}"
Source: "Release\*.dll"; DestDir: "{app}"
Source: "..\NoteAppUI\Resources\icon.ico"; DestDir: "{app}"

[Icons]                                             
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; WorkingDir: "{app}"; IconFilename: {app}\icon.ico
Name: "{group}\uninslall"; Filename: "{uninstallexe}"; WorkingDir: "{app}"; IconFilename: {app}\icon.ico
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon; IconFilename: {app}\icon.ico


[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent


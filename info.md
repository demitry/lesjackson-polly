# Fault Handling with Polly and .NET 6
Episode 1 - Season 5
Transient Fault Handeling Polly

Policies
Retry Policies
.NET 6 SDK (free)

dotnet --version
5.0.403
dotnet --version
6.0.101

need .NET 6

dotnet new webapi -n ResponseService

Template List: 
dotnet new --list
These templates matched your input: 

Template Name                                 Short Name           Language    Tags
--------------------------------------------  -------------------  ----------  -------------------------------------
ASP.NET Core Empty                            web                  [C#],F#     Web/Empty
ASP.NET Core gRPC Service                     grpc                 [C#]        Web/gRPC
ASP.NET Core Web API                          webapi               [C#],F#     Web/WebAPI
ASP.NET Core Web App                          razor,webapp         [C#]        Web/MVC/Razor Pages
ASP.NET Core Web App (Model-View-Controller)  mvc                  [C#],F#     Web/MVC
ASP.NET Core with Angular                     angular              [C#]        Web/MVC/SPA
ASP.NET Core with React.js                    react                [C#]        Web/MVC/SPA
ASP.NET Core with React.js and Redux          reactredux           [C#]        Web/MVC/SPA
Blazor Server App                             blazorserver         [C#]        Web/Blazor
Blazor WebAssembly App                        blazorwasm           [C#]        Web/Blazor/WebAssembly/PWA
Class Library                                 classlib             [C#],F#,VB  Common/Library
Console App                                   console              [C#],F#,VB  Common/Console
dotnet gitignore file                         gitignore                        Config
Dotnet local tool manifest file               tool-manifest                    Config
EditorConfig file                             editorconfig                     Config
global.json file                              globaljson                       Config
MSTest Test Project                           mstest               [C#],F#,VB  Test/MSTest
MVC ViewImports                               viewimports          [C#]        Web/ASP.NET
MVC ViewStart                                 viewstart            [C#]        Web/ASP.NET
NuGet Config                                  nugetconfig                      Config
NUnit 3 Test Item                             nunit-test           [C#],F#,VB  Test/NUnit
NUnit 3 Test Project                          nunit                [C#],F#,VB  Test/NUnit
Protocol Buffer File                          proto                            Web/gRPC
Razor Class Library                           razorclasslib        [C#]        Web/Razor/Library/Razor Class Library
Razor Component                               razorcomponent       [C#]        Web/ASP.NET
Razor Page                                    page                 [C#]        Web/ASP.NET
Solution File                                 sln                              Solution
Web Config                                    webconfig                        Config
Windows Forms App                             winforms             [C#],VB     Common/WinForms
Windows Forms Class Library                   winformslib          [C#],VB     Common/WinForms
Windows Forms Control Library                 winformscontrollib   [C#],VB     Common/WinForms
Worker Service                                worker               [C#],F#     Common/Worker/Web
WPF Application                               wpf                  [C#],VB     Common/WPF
WPF Class library                             wpflib               [C#],VB     Common/WPF
WPF Custom Control Library                    wpfcustomcontrollib  [C#],VB     Common/WPF
WPF User Control Library                      wpfusercontrollib    [C#],VB     Common/WPF
xUnit Test Project                            xunit                [C#],F#,VB  Test/xUnit



code ResponseService -r



PS D:\src\LesJackson\lesjackson-polly\ResponseService> dotnet run
Building...
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: https://localhost:7236
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5198        
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]

Note 1: Ports are different 
.NET 5 - was 5000, 5001
here - pseudo-random ports

Note 2:
Check proj file:
<Nullable>enable</Nullable>

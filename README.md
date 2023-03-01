# ProtoReg
Create your own protocol!
## WARNING! 
DO NOT CREATE AN ISSUE WITHOUT CHECKING IF YOUR RUNNING THE PROGRAM AS ADMIN. ANYONE WHO MAKES AN ISSUE WITHOUT CHECKING WILL BE IGNORED.
## Note
If using for a web browser the web browser might need to be restarted.
## One more note
The DLL is not .NET 6 or .NET 7 compatible. If you need this package in those runtimes, [Copy this code into a new file in your project.](https://raw.githubusercontent.com/Awire9966/ProtoReg/main/ProtoReg/Main.cs)
## API Documentation
To use Add a refrence to ProtoReg by adding at the top of your code: ``` using ProtoReg```
Aftewards you can call the one and only method.
```public static void Register(string protocolname, string openapp, bool allowargs = true)
   Registrar.Register("Protocol Name Here", "Executable path here", bool allow arguments (True if not specified.) );

```



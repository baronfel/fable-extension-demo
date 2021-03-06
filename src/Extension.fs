module Extension

// // The module 'vscode' contains the VS Code extensibility API
// // Import the module and reference it with the alias vscode in your code below.
// module VSCode =
//     type CommandStatic =
//         abstract registerCommand: commandName: string * callback: (ResizeArray<option<obj>> -> option<obj>) -> Disposable

//     and WindowStatic = 
//         abstract showInformationMessage: message: string -> unit

//     and VSCodeStatic =
//         abstract commands: CommandStatic
//         abstract window: WindowStatic


//     and Disposable =
//         abstract dispose: unit -> obj

//     and ExtensionContext =
//         abstract subscriptions: Disposable ResizeArray

//     /// This is what all of the functionality hangs off of
//     let vscode: VSCodeStatic = Fable.Core.JsInterop.importAll "vscode"

open Fable.Import.VSCode.Vscode
open Fable.Core.JS

// this method is called when your extension is activated
// your extension is activated the very first time the command is executed
let activate (context: ExtensionContext) =

    // Use the console to output diagnostic information (console.log) and errors (console.error)
    // This line of code will only be executed once when your extension is activated
    console.log "Congratulations, your extension 'my-fable-extension' is now active!"
    
    // The command has been defined in the package.json file
    // Now provide the implementation of the command with registerCommand
    // The commandId parameter must match the command field in package.json
    let disposable = 
        commands.registerCommand("my-fable-extension.helloWorld", fun args ->
            // The code you place here will be executed every time your command is executed
            // Display a mhttps://docs.microsoft.com/en-us/visualstudio/containers/container-msbuild-properties?view=vs-2022https://docs.microsoft.com/en-us/visualstudio/containers/container-msbuild-properties?view=vs-2022essage box to the user
            window.showInformationMessage("Hello World from my-fable-extension!");
            None
        )
    context.subscriptions.Add (unbox (box disposable))
    ()

// this method is called when your extension is deactivated
let deactivate () = ()

(*
    The "open" instruction is the same as "Imports" in VB .NET and "using" in C#. The namespaces are the same ones as well. The difference between mentioned languages is general language structure.
*)
open System;
open System.IO

[<EntryPoint>] //marking the beggining of debugging, everything before is classified as a preprocessor
let main _ =
    //root function body
    //NOTE: the "_" arguement is the more universal replacement for "varg". It is completely up to you which one you will choose. I recommend using the underscore.
    Console.ReadKey(true) |> ignore; //the "|> ignore" operation should be used on functions, which have an unnecessary return.
    //If your function is meant to return a value (an arithmetic operation, for example), this is the only case when an explicit value to be returned is required.
    0; //The final expression in a function is always the return code.

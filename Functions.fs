module Functions
    open System;
    open System.IO;
    
    let absolute(n:int64) =
        if (n < 0) then
            let mutable v = n;
            v <- (-v);
            printfn("The absolute value of %i is %i.") n v;
            v;
        else
            let mutable v = n;
            printfn("The absolute value of %i is %i.") n v;
            v;
        
    let isEven(n:int) =
        if ((n % 2 = 0) && not(n = 0)) then
            let __even:bool = true;
            printfn("%i is an even value.") n;
        else
            let __even:bool = false;
            printfn("%i is not an even value.") n;
            
    let swap(x:int, y:int) =
        let mutable p:int = x;
        let mutable q:int = y;
        let temp = p;
        p <- q;
        q <- temp;
        
    let readFromFileMatch(path:string, word:string) =
        let s:string[] = File.ReadAllLines(path);
        for n in s do
            if (n = word)
                File.AppendAllText("result1.txt", (n + "\n");

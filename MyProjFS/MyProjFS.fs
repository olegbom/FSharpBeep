module MyProjFS
open System

[<EntryPoint>]
let main argv =
    printfn "Hello World!!SD"
    

    let getMeTone index = 
        let la = 440 
        int (float la * Math.Pow(2.0,float index/12.0))

    Console.Beep(getMeTone 0, 200)
    Console.Beep(getMeTone 2, 200)
    Console.Beep(getMeTone 2, 200)
    Console.Beep(getMeTone 0, 200)
    Console.Beep(getMeTone 2, 200)
    Console.Beep(getMeTone 2, 200)
    Console.Beep(getMeTone 0, 200)
    0 // return an integer exit code

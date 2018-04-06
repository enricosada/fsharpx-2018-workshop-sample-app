// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv =
    let c = MyLibrary.helloMessage "F# eXchange"
    printfn "%s" c

    MyLibrary.downloadFrom "https://enricosada.github.io/fsharpx-2018-workshop/assets/hello.txt"
    |> Async.RunSynchronously
    |> printfn "%s"

    0 // return an integer exit code

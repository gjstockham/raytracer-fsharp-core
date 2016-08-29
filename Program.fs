// Learn more about F# at http://fsharp.org

open System
open System.IO

[<EntryPoint>]
let main argv = 
    let nx = 200
    let ny = 100
    let fs = File.Create("out.ppm")
    let w = new StreamWriter(fs)
    w.WriteLine("P3")
    w.WriteLine(String.Format("{0} {1}", nx, ny))
    w.WriteLine("255")
    for j in (ny-1) .. -1 .. 0 do
        for i in 0 .. (nx-1) do
            let r = (float i) / (float nx)
            let g = (float j) / (float ny)
            let b = 0.2
            w.WriteLine(String.Format("{0} {1} {2}", round(255.99 * r), round(255.99 * g), round(255.99 * b)))
    0

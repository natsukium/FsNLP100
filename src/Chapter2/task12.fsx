open System.IO

let args : string [] = fsi.CommandLineArgs
let col = int args.[2]
let filePath = args.[3]
let file = File.ReadAllLines(filePath)

[ for line in file -> line.Split('\t').[col - 1] ]
|> List.iter (printfn "%s")

open System.IO

let filePath = fsi.CommandLineArgs.[1]

File.ReadAllLines(filePath).Length |> printfn "%d"

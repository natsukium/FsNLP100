open System.IO

let filePath = fsi.CommandLineArgs.[1]

File.ReadAllLines(filePath)
|> Array.map (fun s -> s.Replace("\t", " "))
|> Array.iter (printfn "%s")

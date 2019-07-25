open System

let reverseLowerCase c = 219 - int c |> char

let cipher str =
    str
    |> Seq.map (function
                | c when Char.IsLower c -> reverseLowerCase c
                | c -> c
                >> string)
    |> Seq.reduce (+)

"Hello F#!"
|> cipher
|> printfn "%A"

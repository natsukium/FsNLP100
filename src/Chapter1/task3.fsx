let decomposeAndCount (str : string) = str.Split(' ') |> Seq.map String.length

"Now I need a drink, alcoholic of course, after the heavy lectures involving \
quantum mechanics."
|> decomposeAndCount
|> printfn "%A"

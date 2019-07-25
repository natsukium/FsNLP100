let generateTemplate x y z = string x + "時の" + string y + "は" + string z

generateTemplate 12 "気温" 22.4 |> printfn "%s"

let getOddIndices (str : string) =
    seq {
        for i in 0..str.Length - 1 do
            if i % 2 = 1 then yield str.[i]
    }
    |> Seq.map string
    |> String.concat ""

getOddIndices "パタトクカシーー" |> printfn "%s"

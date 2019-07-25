let stringReverse (str : string) =
    str
    |> Seq.rev
    |> Seq.map string
    |> String.concat ""

stringReverse "stressed" |> printfn "%s"

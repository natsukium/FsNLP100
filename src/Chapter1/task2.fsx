let stringConcat (str1 : string) (str2 : string) =
    let minLength = Array.min [| str1.Length; str2.Length |]
    seq {
        for i in 0..minLength - 1 -> string str1.[i] + string str2.[i]
    }
    |> Seq.reduce (+)

stringConcat "パトカー" "タクシー" |> printfn "%s"

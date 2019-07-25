let genElemMap (l : int []) (str : string) =
    let s = str.Split(' ')
    seq {
        for i in 1..s.Length do
            if Seq.contains i l then yield string s.[i - 1].[0]
            else yield s.[i - 1].[0..1]
    }
    |> Seq.zip (seq {
                    for i in 1..s.Length -> i
                })
    |> Map.ofSeq

let singleList = [| 1; 5; 6; 7; 8; 9; 15; 16; 19 |]

"Hi He Lied Because Boron Could Not Oxidize Fluorine. New Nations Might Also \
Sign Peace Security Clause. Arthur King Can."
|> genElemMap singleList
|> printfn "%A"

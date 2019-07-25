let makeNGram (n : int) (sequence : seq<_>) =
    let s = Seq.toList sequence
    seq {
        for i in 0..s.Length - n -> s.[i..i + n - 1]
    }

// word n-gram
"I am an NLPer".Split(' ')
|> makeNGram 2
|> printfn "%A"
// string n-gram
"I am an NLPer"
|> makeNGram 2
|> printfn "%A"

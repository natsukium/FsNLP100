open System

let permuteWord str =
    match String.length str with
    | n when n <= 4 -> str
    | n ->
        let rnd = Random()

        let middle =
            str.[1..n - 2]
            |> Seq.sortBy (fun _ -> rnd.Next())
            |> Seq.map string
            |> Seq.reduce (+)
        string str.[0] + middle + string str.[n - 1]

let typoglycemia (str : string) =
    str.Split(' ')
    |> Seq.map permuteWord
    |> String.concat " "

"I couldn't believe that I could actually understand what I was reading : the phenomenal power of the human mind ."
|> typoglycemia
|> printfn "%s"

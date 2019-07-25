#load "./task5.fsx"

open Microsoft.FSharp.Collections
open Task5

let x =
    "paraparaparadise"
    |> makeNGram 2
    |> set

let y =
    "paragraph"
    |> makeNGram 2
    |> set

let except x y = x - Set.intersect x y

Set.union x y |> printfn "Union: %A"
except x y |> printfn "Except: %A"
Set.intersect x y |> printfn "Intersect: %A"

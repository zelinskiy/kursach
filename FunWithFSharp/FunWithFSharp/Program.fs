
let f n = List.filter (fun x -> x % 3 = 0 || x % 5 = 0 ) [1..n] 
            |> List.fold (+) 0

let rec qsort xs = 
    let smaller = xs |> List.filter(fun e -> e < xs.Head)
    let larger = xs |> List.filter(fun e -> e > xs.Head)
    match xs with
    | [] -> []
    | _ -> qsort(smaller)@[xs.Head]@qsort(larger)


let rec reverse' (xs:List<int>) (ys:List<int>)=
    match xs with
    | [] -> ys
    | _ -> reverse' xs.Tail ys@[xs.Head]

let reverse l = reverse' l []



let rec merge a b acc =
    match a,b with
    | [], [] ->  acc
    | [], b -> acc@reverse b
    | a, [] -> acc@reverse a
    | ha::ta, hb::tb ->
        match ha < hb with
        | true -> merge ta b acc@[ha]
        | false -> merge a tb acc@[hb]

let rec max' l acc =
    match l with
    | [] -> acc
    | _ ->  
        match l.Head > acc with
        | true -> max' l.Tail l.Head
        | false -> max' l.Tail acc

let max l = max' l l.Head



let x = merge [1;3;5;7] [2;4;6;7;8;9;10;11;13] [] |> reverse

let y = max [10;4;12;5;7;9;2;4;7;1]

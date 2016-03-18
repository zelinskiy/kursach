
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



let rec len' xs n = 
    match xs with
    | [] -> n
    | _ -> len' xs.Tail n+1

let len xs = len' xs 0

let rec merge' a b acc =
    match a,b with
    | [], [] ->  acc
    | [], b -> acc@reverse b
    | a, [] -> acc@reverse a
    | ha::ta, hb::tb ->
        match ha < hb with
        | true -> merge' ta b acc@[ha]
        | false -> merge' a tb acc@[hb]

let merge a b = merge' a b [] |> reverse


let rec msort xs = 
    let mid = (len xs)/2
    let (M, N) = List.splitAt mid xs
    match xs with 
    | [] -> []
    | [a] -> [a]
    | L -> merge (msort M) (msort N)



let rec max' l acc =
    match l with
    | [] -> acc
    | _ ->  
        match l.Head > acc with
        | true -> max' l.Tail l.Head
        | false -> max' l.Tail acc

let max l = max' l l.Head






let x = msort [2;4;6;7;8;9;10;11;13]

let y = msort [10;4;12;5;7;9;2;4;7;1]

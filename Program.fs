// Learn more about F# at http://fsharp.net
open System
module Happy =
    let mutable l:list<int> = []
(*
let Squared number (allNumbers:list<int>) =
    let squared = number * number
    Happy.l <- squared :: Happy.l
    ()
    
let main() =
    for i in 1..100 do
        let squared = Squared i Happy.l
        ()
    for i in Happy.l do
        printf "%i  " i
    
main()
*)



let rec happy number (allNumbers: list<int>) =
    printf "%i" number
    match number with
    | 0 -> "Sad"
    | 1 -> "Happy"
    | n ->
        if (List.exists ( fun elem -> elem = number) allNumbers) then "Sad"
        else
            let newList = number:: allNumbers
            let numberAsString = (string number)
            let mutable sumOfSquares = 0
            for digit in numberAsString do
                let i = ((int digit) - (int '0'))
                sumOfSquares <- sumOfSquares + i * i
            printf " -> "
            (happy sumOfSquares newList)

for i in 1..100 do
    Console.WriteLine("{0}   || {1} is: {2}", String.Empty, i, (happy i []))
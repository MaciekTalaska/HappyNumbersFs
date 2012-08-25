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



let rec is_happy number (allNumbers: list<int>) =
    let newList = number :: allNumbers
    match number with
    | 0 -> (false, newList)
    | 1 -> (true, newList)
    | n ->
        if (List.exists ( fun elem -> elem = number) allNumbers) then (false, newList)
        else
            let numberAsString = (string number)
            let mutable sumOfSquares = 0
            for digit in numberAsString do
                let i = ((int digit) - (int '0'))
                sumOfSquares <- sumOfSquares + i * i
            (is_happy sumOfSquares newList)

let print_sequence (allNumbers: list<int>) =
    Console.Write("Seq: | ")
    for number in allNumbers do
        Console.Write("{0}->", number)
    Console.Write("\b")
    Console.WriteLine(" | ")
    ()

let reverseList list = 
    List.fold (fun acc elem -> elem::acc) [] list

let rec print_sequence_recursive( allNumbers: list<int>) =
    if allNumbers.Length > 1 then (print_sequence_recursive allNumbers.Tail)
    printf "%i " allNumbers.[0]

let print_sequence_reverse( numbers: list<int> ) =
    printf "Seq | "
    (print_sequence_recursive numbers)
    printf "|"

for i in 1..100 do
    let mutable happysad = (is_happy i [])
    Console.WriteLine("{0} is: {1}", i, (if fst(happysad) = true then "Happy" else "Sad"))
    (print_sequence_reverse (snd happysad))
    printf "\n" // go to new line

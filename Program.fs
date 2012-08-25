﻿// Learn more about F# at http://fsharp.net
namespace HappyNumbers
open System
open Utils
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
    let rec IsHappy number (allNumbers: list<int>) =
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
                (IsHappy sumOfSquares newList)

    for i in 1..2 do
        let happysad = (IsHappy i [])
        Console.WriteLine("{0} is: {1}", i, (if fst(happysad) = true then "Happy" else "Sad"))
        (print_sequence_reverse (snd happysad))
        printf "\n" // go to new line

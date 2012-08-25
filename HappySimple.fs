// Learn more about F# at http://fsharp.net
namespace HappyNumbers
open System
open Utils
module Happy =

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

    for i in 1..20 do
        let happysad = (IsHappy i [])
        Console.WriteLine("{0} is: {1}", i, (if fst(happysad) = true then "Happy" else "Sad"))
        (printSequenceReverse (snd happysad))
        printf "\n" // go to new line
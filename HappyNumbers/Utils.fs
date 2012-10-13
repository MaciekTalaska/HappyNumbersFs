namespace HappyNumbers
open System
module Utils =

    let printSequence (allNumbers: list<int>) =
        Console.Write("Seq: | ")
        for number in allNumbers do
            Console.Write("{0}->", number)
        Console.Write("\b")
        Console.WriteLine(" | ")

    let reverseList list = 
        List.fold (fun acc elem -> elem::acc) [] list

    let rec printSequenceRecursive( allNumbers: list<int>) =
        if allNumbers.Length > 1 then (printSequenceRecursive allNumbers.Tail)
        printf "%i " allNumbers.[0]

    let printSequenceReverse( numbers: list<int> ) =
        printf "Seq | "
        (printSequenceRecursive numbers)
        printf "|"    
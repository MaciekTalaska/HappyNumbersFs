namespace HappyNumbers
open System
module Utils =

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
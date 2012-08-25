namespace HappyNumbers
open System
open Utils
module HappyFullRecursive =

    let rec SumOfSquares (numberAsString:string) index sum =
        if index < numberAsString.Length then
            let i = ((int numberAsString.[index]) - (int '0'))
            (SumOfSquares numberAsString (index+1) (sum+i*i))
        else
            sum

    let SumOfAllSquares number =
        let numberAsString = (string number)
        SumOfSquares numberAsString 0 0 

    let rec IsHappy number (allNumbers: list<int>) =
        let newList = number :: allNumbers
        if number = 0 then (false, newList)
        elif number = 1 then (true, newList)
        elif (List.exists (fun elem -> elem = number) allNumbers) then (false, newList)
        else
            let sum = SumOfAllSquares number
            (IsHappy sum newList)

    for i in 1.. 3 do
        let happy = (IsHappy i [])
        Console.WriteLine("{0} is: {1}", i, (fst happy)) 
        (print_sequence_reverse (snd happy))
        printf "\n"

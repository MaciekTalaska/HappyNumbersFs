namespace HappyNumbers.Tests

open System
open HappyNumbers
open NUnit.Framework
open FsUnit

module SimpleTests =

(*
[<TestFixture>]
type HappyNumbersTest ()=
*)

    [<Test>]
    let ``0 is unhappy`` () =
        fst(Happy.IsHappy 0 [] ) |> should be False

    [<Test>]
    let ``1 is happy`` () =
        fst(Happy.IsHappy 1 []) |> should be True

    [<Test>]
    let ``2 is unhappy`` () =
        fst(Happy.IsHappy 2 [] ) |> should be False 

    [<Test>]
    let ``3 is unhappy`` () =
        fst(Happy.IsHappy 3 [] ) |> should be False 

    [<Test>]
    let ``4 is unhappy`` () =
        fst(Happy.IsHappy 4 [] ) |> should be False 

    [<Test>]
    let ``5 is unhappy`` () =
        fst(Happy.IsHappy 5 [] ) |> should be False 

    [<Test>]
    let ``6 is unhappy`` () =
        fst(Happy.IsHappy 6 [] ) |> should be False 

    [<Test>]
    let ``7 is unhappy`` () =
        fst(Happy.IsHappy 7 [] ) |> should be True 

    [<Test>]
    let ``8 is unhappy`` () =
        fst(Happy.IsHappy 8 [] ) |> should be False 

    [<Test>]
    let ``9 is unhappy`` () =
        fst(Happy.IsHappy 9 [] ) |> should be False 

    [<Test>]
    let ``10(0..) is always happy...`` () =
        fst(Happy.IsHappy 10 [] ) |> should be True
        fst(Happy.IsHappy 100 [] ) |> should be True
        fst(Happy.IsHappy 1000 [] ) |> should be True 

    [<Test>]
    let ``7 and all numbers from the sequence are happy `` () =
        let happysad =  Happy.IsHappy 7 []
        fst(happysad) |> should be True
        for i in snd(happysad) do
            fst(Happy.IsHappy i [] ) |> should be True

    [<Test>]
    let ``5 and all numbers fro sequence are sad`` () = 
        let happysad = Happy.IsHappy 5 []
        fst(happysad) |> should be False
        for i in snd(happysad) do
            fst(Happy.IsHappy i []) |> should be False
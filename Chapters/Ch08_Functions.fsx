module FunctionAsThings = 

    let plus3 x = x + 3
    let times2 x = x * 2
    let square = (fun x -> x * x)
    let addThree = plus3

    let listOfFunctions = [addThree; times2; square];

// iterate and apply functions
    for fn in listOfFunctions do
        let result = fn 10 
        printfn "If 10 is the input, the output is %i" result

// function as input
    let evalWith5ThenAdd2 fn = fn(5) + 2
    let add1 x = x + 1

    let result1 = evalWith5ThenAdd2 add1 
    let result2 = evalWith5ThenAdd2 square

// function as output
    let adderGenerator numberToAdd = fun x -> numberToAdd + x

    let added1 = adderGenerator 1
    let result3 = added1 2

    let added100 = adderGenerator 100
    let result4 = added100 2 

module Currying =

    let add x y = x + y

    let adder x = fun y -> x + y

    let result1 = add 1 2
    let result2 = adder 1 2

module PartialApplication =

    let sayGreeting greeting name = printfn "%s %s" greeting name

    let sayHello = sayGreeting "Hallo"

    let sayGoodbye = sayGreeting "Chao"

    sayHello "Paul"
    sayGoodbye "Paul"

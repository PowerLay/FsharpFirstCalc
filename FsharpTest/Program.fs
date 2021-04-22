open System

[<EntryPoint>]
let main argv =
    printfn "Добро пожаловать в мой первый калькултор на языке F#"
    printf "Введите операцию> "
    let operation = System.Console.ReadLine()
    printf "Введите первое число> "
    let a = System.Console.ReadLine()|>int
    printf "Введите второе число> "
    let b = System.Console.ReadLine()|>int
    let addition x y = x + y
    let subtraction x y = x - y
    let multiply x y = x * y
    let divide x y = x / y 

    match operation with
    | "+" -> printfn("The result is: %d")(addition a b)
    | "-" -> printfn("The result is: %d")(subtraction a b)
    | "*" -> printfn("The result is: %d")(multiply a b)
    | "/" -> printfn("The result is: %d")(divide a b)

    0 // return an integer exit code
module Oware


type StartingPosition =
    | South
    | North

type Side =
    | South
    |North

type House ={
num : int
side : Side
seedsnum :int
}

type Gamestates =
      |South's_Turn 
      |North's_Turn
      |Draw
      |South_Won
      |North_won

type player ={
houses : House*House*House*House*House*House
ballsCollected : int
}

type Board = {
player1 : player
player2 : player
state : Gamestates
}

let getSeeds n board = failwith "Not implemented"
  
let useHouse n board = failwith "Not implemented"

let start position = failwith "Not implemented"

let score board =
    ()
    failwith "Not implemented"

let gameState board = failwith "Not implemented"

[<EntryPoint>]
let main _ =
    printfn "Hello from F#!"
    //call the fun game
    0 // return an integer exit code

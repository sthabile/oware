module Oware


type StartingPosition =
    | South
    | North


type House ={
HouseNum : int
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

let start position =
    let ReturnGame = {player1= {Houses=({{HouseNum=1};{seedsnum=0}},{{num=2};{seedsnum=0}},{{num=3};{seedsnum=0}}, {{num=4};{seedsnum=0}},{{num=5};{seedsnum=0}},{{num=6};{seedsnum=0}})} ; ballscollected =0};
                     {player2= {Houses=({{HouseNum=7};{seedsnum=0}},{{num=8};{seedsnum=0}},{{num=9};{seedsnum=0}}, {{num=10};{seedsnum=0}},{{num=11};{seedsnum=0}},{{num=12};{seedsnum=0}})} ; ballscollected =0};
                     state =  North's_Turn }
 
                     (*an initiated game*)
   
   (*use a match expression to change the who is playing based on the input position*)
    match position with
    | South -> {ReturnGame with state = South's_Turn}
    | North -> {ReturnGame with state = North's_Turn}
    | _ -> failwith "Not implemented"
    

let score board =
    ()
    failwith "Not implemented"

let gameState board =
    match board with
    |{player1=_;player2=_ ;state= Draw} -> "Draw"
    |{player1=_;player2=_ ;state= North's_Turn} -> "Draw"
    |{player1=_;player2=_ ;state= South's_Turn} -> "South's Turn"
    |{player1=_;player2=_ ;state= North_won} -> "North Won"
    |{player1=_;player2=_ ;state= South_Won} -> "South Won"
    | _ ->  failwith "Not implemented"

  

[<EntryPoint>]
let main _ =
    printfn "Hello from F#!"
    //call the fun game
    0 // return an integer exit code

﻿module Oware

open System.Data


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

let getSeeds n board =
    match board with
    |{player1=a;player2=b;state=c} -> match a.houses with
                                      |(e,f,g,h,i,j)  -> match n with
                                                         |e.HouseNum -> e.seedsnum
                                                         |f.HouseNum -> f.seedsnum
                                                         |g.HouseNum -> g.seedsnum
                                                         |h.HouseNum -> h.seedsnum
                                                         |i.HouseNum -> i.seedsnum
                                                         |j.HouseNum -> j.seedsnum
                                                         | _ -> (*Match the houses of player 2*)
                                                 
                                                           

    | _ ->failwith "Not implemented"
  
let useHouse n board =

    failwith "Not implemented"

let start position =
  (*  let MyHouse = 
        { HouseNum=0;
        seedsnum=0}
    let p1 =
        { ({MyHouse with HouseNum=1},{MyHouse with HouseNum=2},{MyHouse with HouseNum=3},{MyHouse with HouseNum=4},{MyHouse with HouseNum=5},{MyHouse with HouseNum=6})
         ballsCollected=0}

    let p2 =
        { ({MyHouse with HouseNum=1},{MyHouse with HouseNum=2},{MyHouse with HouseNum=3},{MyHouse with HouseNum=4},{MyHouse with HouseNum=5},{MyHouse with HouseNum=6})
         ballsCollected=0}

    let ReturnedGame= 
        { p1;p2;state=Draw}
   
    (*an initiated game*)
   
   (*use a match expression to change the who is playing based on the input position*)
    match position with
    | South -> {ReturnGame with state = South's_Turn}
    | North -> {ReturnGame with state = North's_Turn}
    | _ -> *)failwith "Not implemented"
    

let score board =
    let southScore =board.player1.ballsCollected
    let northScore= board.player2.ballsCollected
    southScore, northScore
    
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

module Oware

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
    match (n>0&&n<=6),(n>6&&n<=12) with
    |true,false-> match board with
                  |{player1=a;player2=_;state=c} -> let (a,b,c,d,e,f)= a.houses
                                                    match n with 
                                                    |1 -> a.seedsnum
                                                    |2 ->b.seedsnum
                                                    |3 -> c.seedsnum
                                                    |4 -> d.seedsnum
                                                    |5 -> e.seedsnum
                                                    |6 -> f.seedsnum
                                                    | _ -> failwith "Not Implemented"
    |false , true -> match board with
                     |{player1=_;player2=b;state=c} -> let (a,b,c,d,e,f)= b.houses
                                                       match n with 
                                                       |1 -> a.seedsnum
                                                       |2 ->b.seedsnum
                                                       |3 -> c.seedsnum
                                                       |4 -> d.seedsnum
                                                       |5 -> e.seedsnum
                                                       |6 -> f.seedsnum
                                                       | _ -> failwith "Not Implemented"
    | _ -> failwith "Not Implemented"

let useHouse n board =
    
    failwith "Not implemented"

let start position =
    let MyHouse = 
        { HouseNum=0;
        seedsnum=0}
    let p1 =
        { houses=({MyHouse with HouseNum=1},{MyHouse with HouseNum=2},{MyHouse with HouseNum=3},{MyHouse with HouseNum=4},{MyHouse with HouseNum=5},{MyHouse with HouseNum=6});
         ballsCollected=0}

    let p2 =
        {houses = ({MyHouse with HouseNum=7},{MyHouse with HouseNum=8},{MyHouse with HouseNum=9},{MyHouse with HouseNum=10},{MyHouse with HouseNum=11},{MyHouse with HouseNum=12})
         ballsCollected=0}

    let ReturnGame= 
        { player1 =p1;player2=p2;state=Draw}
   
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

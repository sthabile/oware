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
    //get the number of seeds to distribite
    let seeds = getSeeds n board  

    let (a,b,c,d,e,f) =board.player1.houses
    let (g,h,i,j,k,l) =board.player2.houses

    let EmptyTheHouse HouseNumber board = 
         failwith "Just for now"

    let rec DistributeSeeds NumSeeds board =
        failwith "Just for now"

    let updatedHouses = match (n>0&&n<=6) , (n>6&&n<=12) with
                        |true,false -> match n with // match from 1 tp 6
                                        |1 -> EmptyTheHouse 1 board // call empty the house with house number 
                                        |2 -> EmptyTheHouse 2 board
                                        |3 -> EmptyTheHouse 3 board
                                        | 4 -> EmptyTheHouse 4 board
                                        | 5-> EmptyTheHouse 5 board
                                        | 6 -> EmptyTheHouse 6 board
                                        |_ -> failwith "not implemented"
                                        
                        |false, true -> match n with //macth n with 7 to 12  
                                        |7 -> EmptyTheHouse 7 board // call empty the house with house number 
                                        |8 -> EmptyTheHouse 8 board
                                        |9 -> EmptyTheHouse 9 board
                                        | 10 -> EmptyTheHouse 10 board
                                        | 11-> EmptyTheHouse 11 board
                                        | 12-> EmptyTheHouse 12 board
                                        |_ -> failwith "not implemented"
                        | _ -> failwith "Not implemented"

    updatedHouses

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
    
    (*Accepting a board and geneartion scores of captured seeds of both South and North houses*)
let score board =
    let southScore =board.player1.ballsCollected
    let northScore= board.player2.ballsCollected
    southScore, northScore
    
let gameState board =
    match board with
    |{player1=_;player2=_ ;state= Draw} -> "Draw"
    |{player1=_;player2=_ ;state= North's_Turn} -> "North's turn"
    |{player1=_;player2=_ ;state= South's_Turn} -> "South's turn"
    |{player1=_;player2=_ ;state= North_won} -> "North Won"
    |{player1=_;player2=_ ;state= South_Won} -> "South Won"
    | _ ->  failwith "Not implemented"

  

[<EntryPoint>]
let main _ =
    printfn "Hello from F#!"
    //call the fun game
    0 // return an integer exit code

module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz n:int32 =
  let rec subf iter res =
    if res = 1 then iter
    else
      if res % 2 = 0 then
        subf (iter+1) (res/2)
      else 
        subf (iter+1) (3*res+1)
  subf 0 n

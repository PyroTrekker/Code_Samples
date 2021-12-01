module Main where
    data Result t = Result t deriving (Show)
    
    increment (Result d) = Result (d + 1)
    decrement (Result d) = Result (d - 1)

    rtn x = x
    x >>== f = f x

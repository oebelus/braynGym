nTimes :: Integer -> IO ()
nTimes 0 = return ()
nTimes n = do 
    putStrLn "Hello World" 
    nTimes(n-1)

main :: IO ()
main = do
    n <- readLn :: IO Integer
    nTimes n
    

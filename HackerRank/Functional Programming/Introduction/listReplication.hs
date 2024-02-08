repl :: Int -> Int -> [Int]
repl n x =
    if n == 1
        then [x]
        else x : repl (n-1) x

f :: Int -> [Int] -> [Int]
f n (x:xs) = 
    if null xs
        then repl n x
    else repl n x ++ f n xs

main :: IO ()
main = do
    let n = 3
    let a = [1, 2, 3, 4]
    print(f n a)
    

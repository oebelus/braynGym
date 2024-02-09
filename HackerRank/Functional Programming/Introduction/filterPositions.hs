f :: [Int] -> [Int]
f [] = []
f [x] = []
f (x:y:z) = y : f z
    
main = do
    let arr = [2, 5, 3, 4, 6, 7, 9, 8]
    print(f arr)

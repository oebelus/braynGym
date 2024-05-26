fac :: Int -> Int
fac n
  | n < 2 = 1
  | otherwise = n * fac (n-1)

pascal :: Int -> Int -> Int
pascal r c = fac r `div` (fac c * fac (r - c))

generatePascalTriangle :: Int -> [[Int]]
generatePascalTriangle n = [[pascal r c | c <- [0..r]] | r <- [0..n]]

main :: IO ()
main = do
  input <- getLine
  let n = read input :: Int
  let triangle = generatePascalTriangle n
  mapM_ (putStrLn . unwords . map show) triangle

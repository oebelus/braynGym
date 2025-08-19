collatz :: Integer -> Maybe Integer
collatz n
  | n <= 0 = Nothing
  | n == 1 = Just 0
  | even n = fmap (+ 1) (collatz (n `div` 2))
  | odd n = fmap (+ 1) (collatz (3 * n + 1))

import Control.Exception
import Data.Char
import Data.List (find)

data Error = InvalidSpan | InvalidDigit Char deriving (Show, Eq)

largestProduct :: Int -> String -> Either Error Integer
largestProduct size digits
  | size < 0 || size > length digits = Left InvalidSpan
  | size > 0 && digits == "" = Left InvalidSpan
  | all isDigit digits = Right (toInteger (maximum (splitList size (map digitToInt digits) [])))
  | otherwise = case find (not . isDigit) digits of
      Just c -> Left (InvalidDigit c)

splitList :: Int -> [Int] -> [Int] -> [Int]
splitList size d l
  | length d < size = l
  | otherwise = l ++ [product (substring 0 size d)] ++ splitList size (substring 1 (length d) d) l

substring :: Int -> Int -> [Int] -> [Int]
substring start length = take length . drop start

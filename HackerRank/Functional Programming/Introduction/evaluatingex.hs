factorial::Double->Double
factorial 0 = 1
factorial n = n * factorial (n - 1)

power::Double->Double->Double
power x n = (x ** n) / (factorial n)  

expansion::Double->Double->Double
expansion x acc
  | acc == 0 = expansion x (acc + 1) + 1
  | acc < 10 = (power x acc) + expansion x (acc + 1)
  | acc == 10 = 0

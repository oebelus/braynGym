f = open("input.txt", "r")

# 12 red cubes, 13 green cubes, and 14 blue cubes

arr = []
for line in f:
    line = line.strip().split(" ")
    isPossible = True
    red = []
    green = []
    blue = []
    
    for i in range(0, len(line), 2):
        if line[i+1].startswith('red'):
            red.append(int(line[i]))
        elif line[i+1].startswith('green'):
            green.append(int(line[i]))
        elif line[i+1].startswith('blue'):
            blue.append(int(line[i]))
            
    arr.append(int(max(red))*int(max(blue))*int(max(green)))

sum = 0
for i in range(len(arr)):
    sum += arr[i]

print(sum)
    
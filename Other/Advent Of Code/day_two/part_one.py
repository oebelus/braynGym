f = open("input.txt", "r")

# 12 red cubes, 13 green cubes, and 14 blue cubes

count_arr = []
for line in f:
    line = line.strip().split(" ")
    isPossible = True
    for i in range(0, len(line), 2):
        if (line[i+1].startswith('red') and int(line[i]) > 12) or (line[i+1].startswith('green') and int(line[i]) > 13) or (line[i+1].startswith("blue") and int(line[i]) > 14):
            isPossible = False
            break
    if isPossible:
        count_arr.append(line[1])
    
sum = 0
for i in count_arr:
    i = i.rstrip(":")
    sum += int(i)
print(sum)





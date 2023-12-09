import math

first = 1 
last = 2000

def makeprime(first, last):
    if last <= 2:
        return []
    is_prime = [True] * last
    is_prime[0] = False
    is_prime[1] = False
    
    for i in range(2, int(math.sqrt(last)) + 1):
        if is_prime[i]:
            for x in range(i*i, last, i):
                is_prime[x] = False
                
    return [i for i in range(first, last) if is_prime[i]]
    
primes = makeprime(first, last)
#print(primes)
def isMegaPrime(n):
    #print("N:",n)
    dPrimes = [2, 3, 5, 7]
    if n in primes:
        while n > 0:
            if n % 10 not in dPrimes:
                    return False
            n = n // 10
        return True
    return False

#print(len(primes))
count = 0
for i in range(len(primes)):
    if isMegaPrime(primes[i]):
        count += 1
    else:
        count += 0
print(count)

########################################################

import math
import timeit

first = 1
last = 200

def isPrime(x):
    if x == 2 or x == 3: return True
    if x < 2 or x % 2 == 0: return False
    if x < 9: return True
    if x % 3 == 0: return False
    thr = 5
    while thr <= int(math.sqrt(x)):
        if x % thr == 0: return False
        if x % (thr + 2) == 0: return False
        thr += 6
    return True

def isMegaPrime(n):
    #print("N:",n)
    if isPrime(n):
        while n > 0:
            if not isPrime(n % 10):
                    return False
            n = n // 10
        return True
    return False
        

def megaPrimes(first, last):
    count = 0
    mPrimes = []
    for i in range(first, last):
        if i in range(9, 20):
            count += 0
        else:
            if isMegaPrime(i):
                #print(i)
                mPrimes.append(i)
                count += 1
    print(mPrimes)
    return count

print(megaPrimes(first, last))

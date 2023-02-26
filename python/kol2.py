import random

resultA = []
a = int(8)

def taskA(a):
    tab = []
    for i in range(a):
        i = random.randint(1,100)
        if i % 2 != 0:
            tab.append(i)
        if i % 2 == 0:
            tab.append(i + 1)
    return tab

resultA = taskA(a)
print("Result task A:", resultA)


resultB = []

def taskB(b):
    tab = []
    for i in b:
        if(i % 3 == 0 or i % 5 == 0):
            tab.append(i)
    return tab


resultB = taskB(resultA)
print("Result task B", resultB)

def taskC(c):
    base = 0
    for i in c:
        base = base + i
    return base

resultCa = taskC(resultA)
print("Sum for A:", resultCa)
resultCb = taskC(resultB)
print("Sum for B:", resultCb)


resultD = []

def taskD(d):
    tab = []
    for i in range(2,d):
        if(d % i == 0):
            return False
    else:
        tab.append(d)
    return  tab

resultD = taskD(58)
print("Test task D: ", resultD)

resultE = [i for i in resultA if taskD(i)]
print("Task E: ", resultE)

import random

wynikA = []
n = int(8)


def zadA(n):
    numbers = []
    for i in range(n):
        i = random.randint(1, 100)
        if i % 2 != 0:
            numbers.append(i)
        elif i % 2 == 0:
            numbers.append(i + 1)
    return numbers


wynikA = zadA(n)
print("Zadanie A ", wynikA)

wynikB = []


def zadB(a):
    tab = []
    for i in a:
        if (i % 3 == 0 or i % 5 == 0):
            tab.append(i)
    return tab


wynikB = zadB(wynikA)
print("Zadanie B ", wynikB)

wynikCa = 0
wynikCb = 0


def zadC(a):
    base = 0
    for i in a:
        base = base + i
    return round(base / len(a))


wynikCa = zadC(wynikA)
wynikCb = zadC(wynikB)
print("Zadanie C dla A ", wynikCa)
print("Zadanie C dla B ", wynikCb)


wynikD = []


def zadD(a):
    for i in range(2, a):
        if a % i == 0:
            return False
    return i


wynikD = zadD(wynikCa)
print("Zadanie D ", wynikD)

wynikE = [i for i in wynikA if zadD(i)]
print("Zadanie E ", wynikE)

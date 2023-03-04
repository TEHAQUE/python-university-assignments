import random
def bubble_sort(T):
    i = len(T) - 1
    while i >= 1:
        j = 0
        flaga = False
        while j < i:
            if T[j] > T[j+1]:
                flaga = True
                T[j+1], T[j] = T[j], T[j+1]
            j += 1
        print(i , flaga)
        if flaga == False:
            return flaga
        i -= 1

Lista = [-7,2,4,-4,9,-1,0,7,8,10,-15]
bubble_sort(Lista)
print(Lista)

lista =[5,34,6,43]
a = lista[0]

for i in range(1, len(lista)):
    if lista[i]<a:
        a = lista[i]
print(a)

L = []

for i in range(m):
    L.append(random.randint(-10, 10))
    print(L[i], end=' ')

# dodaj instrukcje wyszukiwania
print()

b=[2,3,4,5,6,8,10,15]

def wyszukaj(x,y):
    i=0
    while i < len(x):
        if x[i] == y:
            return True
        else:
            i+=1
    return False
a = int(input("podaj:"))
print(wyszukaj(b, a))

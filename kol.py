# a = {1, 2, 4}
# a.remove(3)
# print(a)
b = {1, 2, 3}
b.add(3)
print(b)
# c = (1, 2, 3)
# c.remove(3)
# print(c)
d = [1, 2, 3]
d.remove(3)
print(d)

thislist = ["apple", "banana", "cherry", "orange", "kiwi", "melon", "mango"]

print(thislist[2:5])
print(thislist[:4])
print(thislist[2:])

thistuple = ("apple", "banana", "cherry")
y = ("orange", )
thistuple += y
print(thistuple)

fruits = ("apple", "banana", "cherry", "kiwi", "melon", "mango")
(green, yellow, *red) = fruits
print(green)
print(yellow)
print(red)

for x in thistuple:
    print("bez indeksu ", x)

for i in range(len(thistuple)):
    print("z indeksem ", thistuple[i])

i = 0
while i < len(thistuple):
    print("while ", thistuple[i])
    i = i + 1
fruits2 = ("apple", "banana", "cherry", "kiwi", "melon", "mango")

tupleSum = thistuple + fruits2
print("suma krotek ", tupleSum)

tupleMultiply = thistuple * 2
print("mniżenie krotek ", tupleMultiply)

thisset = {"apple", "banana", "cherry"}
tropical = {"pineaples", "mango", "papaya"}
thisset.update(tropical)
print("Set ", thisset)

newList = ["kiwi", "orange"]
thisset.update(newList)
print("set + lista", thisset)

newSet = {"dog", "cat", "papuga"}
print("set  ", newSet)
f = newSet.pop()
print("metoda pop", f)

set1 = {"a", "b", "c"}
set2 = {1, 2, 3}
set3 = set1.union(set2)
print("metoda union, set ", set3)

set1.update(set2)
print("metoda update, set", set1)

setX = {"apple", "banana", "cherry"}
setY = {"google", "microsoft", "apple"}

z = setX.intersection(setY)
print("metoda intersection (jedynie wpólne), set", z)

n = setX.intersection_update(setY)
print("dodaje elementy aktywne w obu setach", n)

thisdict = {
    "brand": "Ford",
    "model": "Mustang",
    "year": 1964,
    "colors": ["red", "green", "blue"]
}
thisdict["year"] =2012
thisdict.update({"brand": "Lambo", "model": "Gajardo"})
print("słownik klucze", thisdict.keys())
print("słownik wartości", thisdict.values())
print("słownik kazdy element", thisdict.items())

if "model" in thisdict:
    print("sprawdzanie czy dany klucz istnieje")

for x in thisdict:
    print("wypisanie wszystkich kluczy(for)", x)
for x in thisdict:
    print("wypisanie wszystkich wartosci odpowiadających kluczom(for)", thisdict[x])

for x in thisdict.keys():
    print("pozyskanie kluczy metotda keys()", x)
for x, y in thisdict.items():
    print("pozyskanie kluczy-wartosci metotda keys()", x, y)

print(24//4)

def my_function(country = "Norway"):
    print("I am from " + country)

my_function("Sweden")
my_function("Poland")
my_function()

lam = lambda a : a + 10
print(lam(5))

arr = ([[1, 2, 3, 4, 5], [6, 7, 8, 9, 0]])
print(arr[0, 1])
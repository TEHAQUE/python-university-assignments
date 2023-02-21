import random as r

names = ["Marek", "Artur", "Adam", "Dawid"]
surnames = ["Pasieka", "Kowalski", "Kowadło", "Nowak"]

def createDictionaries(n):
    dictionaries = []
    for i in range(n):
        imie = r.choice(names)
        nazwisko = r.choice(surnames)
        wiek = r.randint(18,70)
        tel = r.randint(5000000,8000000)
        i = dict(name = imie,surname = nazwisko, age = wiek, phone = tel)
        dictionaries.append(i)
    return dictionaries

def find(dane,parametr):
    for i in dane:
        for j in i.values():
            if str(j) == parametr:

                print(i)



ile = 20
slowniki = createDictionaries(ile)
print(slowniki)
wybór = input("Podaj imię: ")


find(slowniki,wybór)

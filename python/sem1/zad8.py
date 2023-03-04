import random as r


tytuły = ["Batman", "Superman", "Thor"]
autorzy = ["Mickiewicz", "Słowacki", "Tuwim"]

def fill(n):
    db = []
    for i in range(n):
        i = dict(title = r.choice(tytuły), authors = r.choice(autorzy), year = r.randint(1000,2000))
        db.append(i)
    return db

def write(baza):
    for x in baza:
        print(x)

def find(dane,parametr):
    for i in dane:
        for j in i.values():
            if str(j) == parametr:
                print(i)


bazadanych = fill(10)
write(bazadanych)
wybór = input("Wybierz: ")
find(bazadanych,wybór)

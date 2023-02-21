print("1. Zadanie 1")
print("2. Zadanie 2.")
print("3. Zadanie 3.")
print("4. Zadanie 4.")
print("5. Zadanie 5.")
menu = int(input("Podaj numer zadania: "))
#Ćwiczenia 1.1

def dodawanie():
    a=float(input("Podaj pierwszą liczbe: "))
    b=float(input("Podaj drugą liczbe: "))
    if a==b:
        wynik = ((a + b) * 3)
        print("Wynik: ", wynik)
    else:
        suma = a + b
        print("Wynik: ", suma)

#Zad 1.1

def wypis():
    z=range(100)
    for i in z:
        print(i)

#Zad 1.4

def liczby():
    Arr = [1,4,-4,7]
    x=min(Arr)
    z=max(Arr)
    print("Najmniejsza liczba to: ", x)
    print("Największa liczba to: ", z)

#Zad 2.1
def komunikat(imie=" z ",nazwisko="parametrem "):
    print("Dowolny komunikat" + imie + nazwisko)

#Zad 3
def srednia(a=0,b=6):
    liczba=b
    suma=0
    srednia=0
    for x in range(a,b):
        suma=suma+x
        srednia=suma/liczba

    wynik=srednia
    print(wynik)


if menu == 1:
    dodawanie()
if menu == 2:
    wypis()
if menu == 3:
    liczby()
if menu == 4:
    komunikat()
if menu == 5:
    srednia()
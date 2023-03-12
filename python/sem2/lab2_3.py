n = int(input("Podaj n "))
m = int(input("Podaj m "))

def table(n,m):
    tab=[]
    for i in range(n+1):
        tab2=[]
        for j in range(m+1):
            tab2.append(0.0)
        tab.append(tab2)
    for k in range(m+1):
        tab[0][k] = 1.0
    for i in range(1,n+1):
        for j in range(1,m+1):
            tab[i][j]=round((tab[i-1][j] + tab[i][j-1])/2 ,2)
    return tab

t= table(n,m)
for i in range(n+1):
    print(t[i])

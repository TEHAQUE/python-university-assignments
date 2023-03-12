n = 20
t = [None] * (n + 1)
def fib(n: int) -> int:
    if n == 0:
        return 0
    if n == 1:
        return 1

    t[0] = 0
    t[1] = 1
    for i in range(2, n + 1):
        t[i] = t[i - 1] + t[i - 2]
    return t[n]

fib(n)
print(t)

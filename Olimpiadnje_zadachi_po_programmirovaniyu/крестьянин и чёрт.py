N = int(input())
u = 0
for j in range(1, N + 1):
    for i in range(2, 18):
        if j % (2 ** i - 1) == 0:
            u += 1
result = N + u
print(result)

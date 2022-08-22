import sympy as sy
from sympy.abc import x

# f(x) = 5x^2 + 10x - 30


f = sy.Lambda(x , 5*x**2 + 10 * x - 30)
print(f(2))

print(sy.solveset(5*x**2 + 10 * x - 30))

# print(sy.plot(5*x**2 + 10 * x - 30))

print(sy.roots(5*x**2 + 10 * x - 30 ) )
from Grammar import Grammar
file = str(input("File: "))
g = Grammar.fromFile(file)
print(g)
print("CFG = "+str(g.isCFG()))

#x = str(input("NonTerminal = "))
#print(g.getProductionsFor(x))
from random import seed
from random import randint
fileName = "RandomNumbers" # Name your file
amountOfNumbers = 1000 # Choose the amount of numbers you want
numberFrom = 1 # From which number it starts ( min number you can get )
numberTo = 1000 # To which number you want it to be ( max number you can get )
seed(1) # Not REAL random, so you need to choose a seed
f= open(fileName+".txt","w+")
for _ in range(amountOfNumbers):
    value = randint(numberFrom, numberTo)
    f.write(str(value)+"\n")
f.close()
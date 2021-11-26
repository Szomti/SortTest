from random import seed
from random import randint
fileName = "RandomNumbers" # Name your file
amountOfNumbers = 1000 # Choose the amount of numbers you want
numberFrom = 1 # From which number it starts ( min number you can get )
numberTo = 1000 # To which number you want it to be ( max number you can get )
seed(1) # Not REAL random, so you need to choose a seed to get other values
f = open(fileName+".txt","w+")
for numbers in range(amountOfNumbers):
    value = randint(numberFrom, numberTo)
    if(numbers<(amountOfNumbers-1)):
        f.write(str(value)+"\n")
    else:
        f.write(str(value))
f.close()
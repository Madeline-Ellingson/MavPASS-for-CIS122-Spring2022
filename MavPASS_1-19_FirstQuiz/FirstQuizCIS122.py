# - Create an array of integers
# - Make a method ElimminateDuplicates that takes in an array
# and gets rid of any duplicate numbers
# - Create a method RemoveHigher that takes in an array
# and removes any number that is not lower than the one before it

# Online Python - IDE, Editor, Compiler, Interpreter
def eliminateDuplicates(aList):

    aNewList = []

    for num in aList:
       for i in range(len(aList)):
            if num != aList[i]:
              if num not in aNewList:
                 aNewList.append(num)

    return aNewList

def removeHigher(aList):
    
    aNewList = []
    
    for num in aList:
        aNewList.append(num)
    
    j = 0
    
    for i in range(len(aList) - 1):
        if aList[j] < aList[i + 1]:
            aNewList.remove(aList[i + 1])
        else:
            if(j < len(aList) - 1):
                j += 1
        
    return aNewList
    
def main():
    
    aList = [8,3,4,5,3,2,1,7,7]

    print(eliminateDuplicates(aList))
    
    aNewList = eliminateDuplicates(aList)
    
    print(removeHigher(aNewList))

main()

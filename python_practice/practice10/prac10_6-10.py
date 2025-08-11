'''10-6 to 10-7'''
while 1:
    try:
        n1 = int(input('enter number1:'))
        n2 = int(input('enter number2:'))
        theSum = n1 + n2
        print(theSum)
    except ValueError:
        print('please enter a number rather other texts')

'''10-8 to 10-9'''
import os
print(os.getcwd())          # 当前工作目录
print(os.listdir('.'))      # 看看这个目录里到底有什么
try:
    with open('cat.txt') as file_object:
        for line in file_object:
            print(line.rstrip())
except FileNotFoundError:
    print('not found the file you want')
    #静默就pass
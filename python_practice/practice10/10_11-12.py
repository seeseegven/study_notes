import json

num = int(input('enter your favorite number:'))

try:
    with open('fav_num.json') as f:
        fav_num = json.load(f)       # ← 这里必须有语句
except FileNotFoundError:
    with open('fav_num.json', 'w') as f:
        json.dump(num, f)            # json.dump 不需要再赋值
    print('I remember your favorite number')
else:
    print(f"I know your favorite number! It's {fav_num}")

'''numbers = [1, 2, 3, 4]
filename = 'number.json'

print('当前工作目录 →', os.getcwd())          # 关键：看看实际路径
print('文件将写到 →', os.path.abspath(filename))

with open(filename, 'w') as f:
    json.dump(numbers, f)

print('写完了，去上面那个目录里找 number.json')'''
'''
class Dog:
    def __init__(self):
        
        pass

    def species(self):
        return 'canine'

dog1 = Dog()'''
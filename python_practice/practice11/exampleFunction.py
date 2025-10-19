import unittest

def get_formatted_name(first, last):
    full_name = f'{first} {last}'
    return full_name.title()

class NamesTestCase(unittest.TestCase):
    '''测试'''
    def test_first_last_name(self): #测试函数需要test打头
        formatted_name = get_formatted_name('janis', 'joplin')
        self.assertEqual(formatted_name, 'Janis Joplin')

if __name__ == '__main__':
     unittest.main()
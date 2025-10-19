import unittest

class Employee:
    def __init__(self, first_name, last_name, salary):
        self.first_name = first_name
        self.last_name = last_name
        self.salary = salary

    def give_raise(self, increment=5000):
        self.salary += increment


class TestClassEmployee(unittest.TestCase):
    def setUp(self):
        self.salary = 5000000
        self.employee = Employee('march', '7th', self.salary)

    def test_give_default_raise(self):
        self.employee.give_raise()
        self.assertEqual(self.employee.salary, self.salary+5000)

    def test_give_custom_raise(self):
        self.employee.give_raise(10000)
        self.assertEqual(self.employee.salary, self.salary+10000)

if __name__ == '__main__':
    unittest.main()
from city_functions import getCityAndCountry
import unittest

class FunctionTest(unittest.TestCase):
    def test_getCityAndCountryPopulation(self):
        formatted_str = getCityAndCountry('santiago', 'chile', 500000)
        self.assertEqual(formatted_str, 'santiago, chile - population 500000')

    def testOptionalPopulation(self):
        formatted_s = getCityAndCountry('santiago', 'chile')
        self.assertEqual(formatted_s, 'santiago, chile - population ')

if __name__ == "__main__":
    unittest.main()
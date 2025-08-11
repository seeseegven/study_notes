'''11-1要求城市和国家，11-2需要加上人口参数'''
def getCityAndCountry(city, country, population = ''):
    return f'{city}, {country} - population {population}'

if __name__ == '__main__':
    print(getCityAndCountry('a','bbb'))


import unittest

class AnonymousSurvey:
    '''调查问卷'''

    def __init__(self, question):
        self.question = question
        self.responses = []

    def show_question(self):
        print(self.question)

    def store_response(self, new_response):
        self.responses.append(new_response)

    def show_results(self):
        print("Survey results:")
        for res in self.responses:
            print(f'- {res}')

'''question = 'What language did you first learn?'
my_survey = AnonymousSurvey(question)

my_survey.show_question()
while 1:
    response = input('Language:')
    if response == 'q':
        break
    my_survey.store_response(response)

my_survey.show_results()'''

class AnonymousTest(unittest.TestCase):
    def setUp(self):
        question = 'What language did you first learn?'
        self.my_survey = AnonymousSurvey(question)
        self.responses = ['English', 'Chinese', 'Spanish']

    def test_store_single_response(self):
        self.my_survey.store_response(self.responses[0])
        self.assertIn(self.responses[0], self.my_survey.responses)

    def test_store_list_response(self):
        for i in self.responses:
            self.my_survey.store_response(i)
        
        for j in self.my_survey.responses:
            self.assertIn(j, self.responses)

if __name__ == '__main__':
    unittest.main()

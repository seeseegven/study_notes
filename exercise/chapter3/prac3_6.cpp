#include <iostream>
#include <string>
using namespace std;
using std::string;

int main(){
    string s1;
    cin >> s1;
    for (char &c : s1) {
        c = 'X';
    }
    cout << s1 << endl;
    return 0;
}
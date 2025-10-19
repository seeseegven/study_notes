#include <iostream>
#include <string>
using namespace std;
using std::string;

int main() {
    string s1, s2;
    getline(cin, s1);
    for (auto c : s1) {
        if (!ispunct(c)) {
            s2 += c;
        }
    }
    cout << s2 << endl;
    return 0;
}
#include <iostream>
#include <string>
using std::string, std::cin, 
std::cout, std::endl;

int main(){
    string s1, s, s2 = "";
    while (cin >> s){
        s1 += s;
        s2 += s;
        s2 += ' ';
    }
    cout << s1 << "\n" << s2;
    return 0;
}
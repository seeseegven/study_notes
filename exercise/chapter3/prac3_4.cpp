#include <iostream>
#include <string>
using std::cin, std::cout, std::endl;
using std::string;

int main(){
    string s1, s2;
    getline(cin, s1);
    getline(cin, s2);
    if (s1 != s2){
        if (s1 > s2){
            cout << s1 << endl;
        }
        else{
            cout << s2 << endl;
        }
    }
    unsigned n1, n2;
    n1 = s1.size();
    n2 = s2.size();
    if (n1 != n2){
        if (n1 > n2){
            cout << n1 << endl;
        }
        else {
            cout << n2 << endl;
        }
    }
    return 0;
}
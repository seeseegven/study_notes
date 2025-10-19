#include <iostream>
#include <string>
using namespace std;
using std::string;

int main(){
    string s1;
    getline(cin, s1);
    auto n = s1.size();
    decltype(n) i = 0, j;
    while (i < n) {
        s1[i] = 'X';
        i++;
    }
    cout << s1 << endl;
    return 0;
}

/*for循环写法：
for (decltype(n) i=0; i < n; ++i){
        s1[i] = 'X';
    }*/
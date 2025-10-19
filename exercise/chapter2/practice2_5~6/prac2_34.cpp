#include <iostream>
using namespace std;

int main(){
    int i = 0, &r = i;
    auto a = r;
    const int ci = i, &cr = ci;
    auto b = ci;
    auto c = cr;
    auto d = &i;
    auto e = &ci;
    const auto f = ci;   //auto忽略顶层const，故要显式加上const，f变为const int
    auto &g = ci;
    const auto &j = 42; //常量引用可以绑定字面值，一个临时变量=42，j引用临时变量。
    cout << a << " " << b << " " << c << " " << d << " " << e << " " << g << endl;
    a = 42; b = 42; c = 42;
    cout << a << " " << b << " " << c << " " << g << endl;
    return 0;
}
#include <iostream>

int main(){
    double dval = 3.14;
    const int &ri = dval;
    dval = 2.5;
    std::cout << dval << " " << ri;
}
#include <iostream>

int main(){
    int a = 37, b = 42;
    int * p = &a;
    int * p1 = &b;
    p = p1;
    std::cout << *p;
    *p = 37;
    std::cout << p << " " << p1
            << " " << *p << " " 
            << *p1 << std::endl;
    return 0;
}
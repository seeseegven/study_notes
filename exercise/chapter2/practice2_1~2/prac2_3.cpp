#include <iostream>

//2.3为预测结果，2.4为编译验证结果。
int main(){
    unsigned u = 10, u2 = 42;
    std::cout << u2 - u << std::endl; //32
    std::cout << u - u2 << std::endl; //(-32)%(2^32)=4294967264, unsigned int简写为unsigned,32位

    int i = 10, i2 = 42;
    std::cout << i2 - i << std::endl; //32
    std::cout << i - i2 << std::endl; //-32
    std::cout << i - u << std::endl; //0
    std::cout << u - i << std::endl; //0
    std::cout << i - u2 << std::endl; //4294967264
    unsigned char a = 42;
    std::cout << u - a << std::endl; //4294967264
    std::cout << i - a << std::endl; //-32
}
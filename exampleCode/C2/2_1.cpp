//类型转换

#include <iostream>

int main(){
    bool b = 42; //b为真
    int i = b;  //b是布尔型，为1，故i=1
    i = 3.14;  //i是int，故i为3
    double pi = i;  //pi为3.0
    unsigned char c = -1; //unsigned char为8位1字节，范围从0-255，c值为(-1)%256=255
    //signed char c2 = 256; 有符号数超出范围，c2为未定义的

    int j = 42;
    if (j)
        j = 0; //42作为布尔值，为1，故执行if

    unsigned u = 10;
    i = -42; //i为int
    std::cout << i + i << std::endl; //输出-84
    std::cout << u + i << std::endl; //(-42)%(2^32)+10

    unsigned u1 = 42, u2 = 10;
    std::cout << u1 - u2 << std::endl; //输出32
    std::cout << u2 - u1 << std::endl; //输出(-32)%(2^32)
    //由于无符号数为负数时，值变为该负数对总范围取余，故for (unsigned u = 10; u>=0;u--)会死循环
    //要避免其与负数比较

    
}

#include <iostream>
#include "Sales_item.h"

int main(){
    Sales_item item1, item2;
    int num = 1;
    if (std::cin >> item1){
        while (std::cin >> item2){
            if (item1.isbn == item2.isbn){
                num += 1;
            }
            else{
                std::cout << "相同的记录有" << num
                          << "条" << std::endl;
                item1 = item2;
                num = 1;
            }
        }std::cout << "相同的记录有o" << num
                   << "条" << std::endl;
    }
    else{
        std::cout << "没有数据" << std::endl;
        return -1;
    }
    return 0;
}

//1_24是测试的，用23的代码测试
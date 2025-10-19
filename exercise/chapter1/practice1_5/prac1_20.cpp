#include <iostream>
#include "Sales_item.h"

int main(){
    Sales_item item;
    while (std::cin >> item){
        std::cout << item;
    }
    std::cout << std::endl;
    return 0;
}

//1.21题:item1 + item2

/*1.20：
#include <iostream>
#include "Sales_item.h"

int main(){
    Sales_item item;
    while (std::cin >> item){
        std::cout << item;
    }
    std::cout << endl;
    return 0;
}
*/
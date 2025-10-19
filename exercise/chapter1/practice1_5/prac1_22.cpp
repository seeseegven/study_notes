#include <iostream>
#include "Sales_item.h"

int main(){
    Sales_item item, total;
    if (std::cin >> total){
        while (std::cin >> item){
            if (total.isbn == item.isbn){
                total += item;
            }
        }
        std::cout << "the same info is " << total;
    }
    else{
        std::cout << "No data" << std::endl;
        return -1;
    }
    return 0;
}
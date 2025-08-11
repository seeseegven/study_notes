#include <iostream>

int main(){
    int currVal = 0, val = 0;
    if (std::cin >> currVal) {
        int cont = 1;
        while (std::cin >> val) {
            if (val == currVal)
                ++cont;
            else {
                std::cout << currVal << " occurs "
                          << cont    << " times" << std::endl;
                currVal = val;
                cont = 1;
            }
        }
    std::cout << currVal << " occurs "
                          << cont    << " times" << std::endl;    
    }
    return 0;
}

/*practice 1.17:    正常输出；每个都输出一次
  practice 1.18:    同上*/
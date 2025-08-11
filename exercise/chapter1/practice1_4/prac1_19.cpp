#include <iostream>

int main(){
    int n1, n2;
    std::cout << "Enter two numbers";
    std::cin >> n1 >> n2;
    if (n1 > n2){
        int t;
        t = n1, n1 = n2, n2 = t;
    }
    while (n1<=n2) {
        std::cout << n1 << "\n";
        n1++;
    }
    return 0;
}
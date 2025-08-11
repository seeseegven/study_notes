#include <iostream>

int main(){
    int n1, n2;
    std::cout << "Enter two numbers";
    std::cin >> n1 >> n2;
    while (n1<=n2) {
        std::cout << n1 << "\n";
        n1++;
    }
    return 0;
}

/* practice1.12:  -100累加到100，sum为0
for (int i=50;i<=100;i++)
for (int 1=10;i>=0;i--)
for (;n1<=n2;n1++){
    std::cout << n1 << "\n";
}*/
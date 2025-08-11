#include <iostream>

int main(){
    int n = 10, sum = 0;
    while (n>=0) {
        sum += n;
        n--;
    }
    std::cout << "The sum of 10 to 0 is " << sum << '\n';
    return 0;
}
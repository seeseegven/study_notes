#include <string>
#include <iostream>
using namespace std;
using std::string;

struct Sales_data {
    string ISBN = "";
    unsigned sold_out = 0;
    double unit_price, sum_price = 0.0;
};

int main(){
    Sales_data data1, data2;
    cin >> data1.ISBN >> data1.sold_out >> data1.unit_price;
    cin >> data2.ISBN >> data2.sold_out >> data2.unit_price;
    if (data1.ISBN == data2.ISBN){
        int sold_sum = data1.sold_out + data2.sold_out;
        cout << sold_sum << endl;
    }
    else{
        cout << "IBSNs are different!";
    }
    return 0;
} 
#ifndef SALES_DATA_H
#define SALES_DATA_H
#include <string>
struct Sales_data {
    std::string ISBN = "";
    unsigned sold_out = 0;
    double unit_price, sum_price = 0.0;
};
#endif
//T2.42
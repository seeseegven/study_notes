#ifndef SALESITEM_H
#define SALESITEM_H
#include <iostream>
#include <string>

class Sales_item {
public:
    Sales_item() : units_sold(0), revenue(0.0) {}
    Sales_item(const std::string &book) : isbn(book), units_sold(0), revenue(0.0) {}
    Sales_item(std::istream &is) { is >> *this; }

    friend std::istream& operator>>(std::istream&, Sales_item&);
    friend std::ostream& operator<<(std::ostream&, const Sales_item&);

    Sales_item& operator+=(const Sales_item&);
    bool same_isbn(const Sales_item &rhs) const { return isbn == rhs.isbn; }
    double avg_price() const;

    std::string isbn;
    unsigned units_sold;
    double revenue;
};

inline bool operator==(const Sales_item& lhs, const Sales_item& rhs) {
    return lhs.units_sold == rhs.units_sold && lhs.revenue == rhs.revenue && lhs.same_isbn(rhs);
}

inline bool operator!=(const Sales_item& lhs, const Sales_item& rhs) {
    return !(lhs == rhs);
}

inline Sales_item& Sales_item::operator+=(const Sales_item& rhs) {
    units_sold += rhs.units_sold;
    revenue += rhs.revenue;
    return *this;
}

inline Sales_item operator+(const Sales_item& lhs, const Sales_item& rhs) {
    Sales_item ret(lhs);
    ret += rhs;
    return ret;
}

inline std::istream& operator>>(std::istream& in, Sales_item& s) {
    double price;
    in >> s.isbn >> s.units_sold >> price;
    if (in)
        s.revenue = s.units_sold * price;
    else
        s = Sales_item();
    return in;
}

inline std::ostream& operator<<(std::ostream& out, const Sales_item& s) {
    out << s.isbn << "\t" << s.units_sold << "\t" << s.revenue << "\t" << s.avg_price();
    return out;
}

inline double Sales_item::avg_price() const {
    return units_sold ? revenue / units_sold : 0;
}

#endif
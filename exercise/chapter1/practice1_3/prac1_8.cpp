# include <iostream>

int main(){
    std::cout << "/*\n";
    std::cout << "*/\n";
    //std::cout << /* "*/" */; 这是错误的
    std::cout << /* "*/" /* "/*" */;
    return 0;
}
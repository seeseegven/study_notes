#include <iostream>
using namespace std;

int main(){
    int j,b;int a[10];
    fill(a,a+10,-1);
    a[0]=8,a[1]=9,a[2]=7;
            j=0;
            b=0;//b是余数
            while (a[j]!=-1) j++;
            for(int k=0;k<j;k++){
                a[k] *= 9;
                a[k] += b;
                b = a[k]/10;
                a[k] %= 10;
            }
            if (b>0) {
                a[j] = b;
                j++;
            }
            for (int i=0;i<10;i++) cout << a[i] << endl;
            int m = j-1;
            b=0;//这里b变成被除数
            while (m>=0) {
                if (b<9){
                    b = b*10+a[m];
                    a[m] = -1;
                    m--;
                    continue;
                }
                

                a[m+1]=b/9;
                b %= 9;
            }
            if (b!=0)
                a[m+1]=b/9;
            for(int i=0;i<10;i++) cout << a[i] << endl;
        
}
#include <iostream>
using namespace std;

int main(){
    int n;

    while (cin >> n){
        int a[1000]={0},b[1000]={0},c[1000]={0},d[1000]={0};
        a[0]=1,b[0]=2,c[0]=4,d[0]=7;
        int e[1000]={0},wei;//进位
        int i=1,f; //记录最大位数
        int *p=a,*q=b,*r=c,*s=d,*sy;
        switch (n) {
            case 1: {
                cout << a[0] << endl;
                break;
            }case 2: {
                cout << b[0] << endl;
                break;
            }case 3: {
                cout << c[0] << endl;
                break;
            }case 4: {
                cout << d[0] << endl;
                break;
            }default:{
                for(int j=5;j<=n;j++){
                    wei = 0;
                    for(int k=0;k<i;k++){
                        e[k] = *(p+k)+*(r+k)+*(s+k)+wei;
                        if (e[k]>=10){
                            wei = e[k]/10;
                            e[k] %= 10;
                        }else{ wei = 0;}
                    }
                    if (wei>0) {
                        i++;
                        e[i-1] = wei;
                    }
                    for(int k=0;k<i;k++) p[k]=e[k];
                    sy=p,p=q,q=r,r=s,s=sy;
                }
                for(int k=i-1;k>=0;k--) cout << e[k];
                cout << endl;
            }
        }
    }
}
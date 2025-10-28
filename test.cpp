#include <iostream>
using namespace std;

int main(){
    int n,cnt=0;
    while (cin >> n) {
        if (n==-1) return 0;
        int i,j,m,b;
        int a[120];
        fill(a,a+120,-1);
        a[0] = 1;
        for(i=1;i<=n;i++){
            j=0;
            b=0;//b是余数
            while (a[j]!=-1) j++;
            for(int k=0;k<j;k++){
                a[k] *= (n+i);
                a[k] += b;
                b = a[k]/10;
                a[k] %= 10;
            }
            if (b>0) {
                a[j] = b;
                j++;
            }
            m = j-1,b=0;//这里b变成被除数
            for (int k=j;k>0;k--) {
                if (b<i){
                    b = b*10+a[m];
                    a[m] = -1;
                    m--;
                }

                a[m+1]=b/i;
                b %= i;
            }
            if (b!=0)
                a[m+1]=b/i;
        }
        m=j-1;
        for (int k=j;k>0;k--) {
            if (b<(n+1)){
                b = b*10+a[m];
                a[m] = -1;
                m--;
            }

            a[m+1]=b/(n+1);
            b %= (n+1);
        }
        if (b!=0)
            a[m+1]=b/(n+1);
        int k,f=1;
        for(k=0;a[k]!=-1;k++);
        for(--k;k>=0;k--) {
            if (f&&!a[k]){
                continue;
            }
            cout << a[k];
            f=0;
        }
    }
}
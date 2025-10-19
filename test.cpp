#include <iostream>
using namespace std;

int main(){
    int n,cnt=0;
    while (cin >> n) {
        if (n==-1) return 0;
        int i,j;
        int a[120],b;
        fill(a,a+120,-1);
        a[0] = 1;
        for(i=1;i<=n;i++){
            j=0;
            b=0;
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
            int m = j-1,b=0;
            cout << a[0] << a[1] << a[2] << endl;
            while (m>=0) {
                if (b<i){
                    b = b*10+a[m];
                    a[m] = -1;
                    m--;
                    continue;
                }
                if (b%i==0) a[m+1] = b/i;
                else a[m]=b/i;
                b %= i;
                m--;
            }
            if (b!=0)
                a[m+1]=b/i;
        }
        long long res = 0;
        int index = 0;
        cout << a[0] << a[1] << endl;
        while (a[index]!=-1) {
            index++;
        }
        for(int k=--index;k>-1;k--) res = res*10+a[k];
        res = (res)/(n+1)*2;
        cnt++;
        cout << cnt << " " << n
             << " " << res << endl;

        cout << '0';
    }
}
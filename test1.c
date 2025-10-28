#include <stdio.h>
int main(void)
{int t,h,m,s;  //变量t用于存储输入的总秒数
 scanf("%d",
&t
);
 s=
t%60
;  //秒
 m=
((t-s)/60)%60
;  //分
 h=
(t-60*m-s)/3600
;  //时
 printf("%d:%02d:%02d\n",h,m,s); // 时分秒之间用英文冒号 间隔
 return 0;
}
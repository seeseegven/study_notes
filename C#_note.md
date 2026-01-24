# 不成体系地记一下C#和unity过程中碰到的问题

<font size=5> 1.unity中需要继承于**MonoBehaviour**的类才能被当成组件加到game object上，且类名首字母要 ***大写*** 才能生效

<font size=5> 2.C#中数据有整型，实型，非字符型。

|整|型| |
|--|--|-|
|字节数|有符号|无符号|
|1|sbyte|byte|
|2|short|ushort|
|4|int|uint|
|8|long|ulong|


|浮|点|型||
|-|---|-|-|
|字节数|名字|精度|后缀|
|4|float|7|f,F|
|8|double|15~16|d,D|
|16|decimal|28~29|m,M|
##### 浮点不加后缀会报错！除非是double(默认)

<font size=5>可用**string.Format**来格式化WriteLine,语法例子

    string testStr = string.Format("枪的名称是：{0},弹匣容量是：  {1},当前子弹数量是：{2},剩余子弹数量是：{3}",
    gunName, capacityInput, currentBulletsInput, remainingBulletsInput);

## 但是
 <font size=5> **$"{}"**格式也可以更便捷地实现格式化，例如

    string testStr = $"枪的名称是：{gunName},弹匣容量是：{capacityInput},当前子弹数量是：" +
    $"{currentBulletsInput}" + "剩余子弹数量���：" + remainingBulletsInput;
    //换行整个"+"连接。

|格|式|化|
|--|--|--|
|c|数字|￥


|转|义|
|--|--|
|\ "|"|
|\ '|'|
|\ 0|空字符|
|\r\n|回车换行|
|\t|<font size=3>水平制表，tab效果|

#### 源代码--CLS编译--CIL(通用中间语言)--CLR编译--机器码 


<font size=5>Parse转换: *string* -> 其他类型：
**wanted_type.Parse(string)**
例如

    string s1 = "18.0";
    int convertedInt = int.Parse(s1); 
    //报错，因为有点，如果是"18"就可以
    float convertedFloat = float.Parse(s1);
    //18.0

<font size=5>任意类型转string，使用 **.ToString**，如

    int num = 123456;
    string strNum = num.ToString("N3");
    string strNum2 = num.ToString();
    Console.WriteLine(strNum); //123,456.000
    Console.WriteLine(strNum2); //123456

<font siez=5>小范围 -> 大范围，自动隐式转换； 大范围 -> 小范围，需显式转换。例如
 
    byte b3 = 100;
    int i3 = b3;//可以
    int i4 = 100;
    byte b4 = (byte)i4;
    //需要显式转换，可能超范围

+=这种快捷运算符不做自动类型提升

#### C#的switch~case语句不允许穿透，必须加break;
#### float不能进switch。

<font size=5>C#里bool和float隔离，没有0/1->false/true的转换，bool只能逻辑判断。

<font size=5>虽然要求方法名称要大写，但似乎小写也没报错。

### 重载：方法名称相同，参数列表不同，根据参数类型或数量来区分不同的方法。详见sln的Part06部分的Class3.

    internal void ShowArray()
    {
        int[] a;
        //声明
        a = new int[5];
        //初始化，感觉比c++麻烦
        a[0] = 10;
        //这倒是和C++一样
        int[] b = new int[3] { 1, 2, 3 };
        //也可以这样赋值，[]里的数字可以不写，写了就必须对应个数。

        bool[] c = { true, false, false, true };
        //也可以声明+初始化+赋值,但是不能拆成不加new的形式。
    }

<font size=5>**foreach (    int    i   in  array)**

<font size=5>**foreach (元素类型(可以var自动推断) 变量名 in 数组名称)**

<font size=5>**还能(int[])这样子转换obj为数组类型，第一次见😂**

### 二维数组初始化居然是**int a[,]**,使用是**a[i,j]**，int a[,] = new int[3,4]

    internal static void Add(params int[] nums)
    {
        int res = 0;
        foreach (var item in nums)
        {
            res += item;
        }
        Console.WriteLine("和为：" + res);
    }
    para.Add(1, 2, 3, 4, 5);
<font size=5> 如上代码所示，加了**params**则可以直接传入不定数量的值甚至**不传**；反之需要传入数组。


<font size=5>**通用类型系统**定义了面向.NET框架的语言的数据类型，包括：
`值类型：存储数据本身`
`引用类型：数据的引用（地址）`

    数据类型
        |——值类型
            |——结构
                |——数值类型
                |——bool
                |——char
            |——枚举
        |——引用类型
            |——接口
            |——类
                |——string
                |——Array
                |——委托

---

    方法的形参
        |——值参数：按值传递
        |——引用参数：按引用传递，要加ref前缀
        |——输出参数：按引用传递，加out前缀，可以返回多个值
        但要求out必须在方法内对形参进行赋值，ref传值必须已赋值

<table>
  <tr><td colspan="3"> 整型 </td></tr>
  <tr><td colspan="2">2 格</td><td></td></tr>
  <tr><td>3 格</td><td>3 格</td><td>3 格</td></tr>
</table>
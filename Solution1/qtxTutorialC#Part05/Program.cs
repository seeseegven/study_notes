// See https://aka.ms/new-console-template for more information
using qtxTutorialC_Part05;
# region 数字格式化
using qtxTutorialC_Part05;

Console.WriteLine("金额：{0:C5}", 123456.789); //金额：￥123,456.79
Console.WriteLine("百分比：{0:P1}", 0.256); //百分比：25.6%
Console.WriteLine("科学计数法：{0:E2}", 123456.7896); //科学计数法：1.235E+005

Console.WriteLine("{0:N4}", 123456.789); //123,456.7890
Console.WriteLine("{0:d2}",5); //05
Console.WriteLine("{0:D4}",5); //0005
Console.WriteLine("{0:f3}", 1.26); //1.3
#endregion
#region 类型转化，others to string && string to others
string s1 = "18";
int convertedInt = int.Parse(s1);
float convertedFloat = float.Parse(s1);
Console.WriteLine(convertedFloat);
Console.WriteLine("{0:f2}",convertedInt);
int num = 123456;
string strNum = num.ToString("N3");
string strNum2 = num.ToString();
Console.WriteLine(strNum); //123,456.000
Console.WriteLine(strNum2); //123456
#endregion
//练习1234，每位数字相加
Console.WriteLine("请输入一个四位数：");
string str = Console.ReadLine();
int res = 0, t;
t = int.Parse(str);
res += t % 10;
res += t / 10 % 10;
res += t / 100 % 10;
res += t / 1000 % 10;
Console.WriteLine($"各位数字之和是：{res}");
Class1.Main1();
Console.ReadLine();







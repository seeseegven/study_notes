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



<table>
  <tr><td colspan="3"> 整型 </td></tr>
  <tr><td colspan="2">2 格</td><td></td></tr>
  <tr><td>3 格</td><td>3 格</td><td>3 格</td></tr>
</table>
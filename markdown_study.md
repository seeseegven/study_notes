<h2>Markdown 学习</h5>

# 标题语法：
## · ‘#’的个数表示几级标题，‘#’越多，标题越小，且#后面要加空格
## · 使用'<h+number> content <h+number>',前面必须要写对格式，后面不对也没事。
## ·使用文本加换行之后的'='或'-'来选择大小，如
abc
-
abc
=

# 段落语法
## 不要用tab或空格缩进，段落间距仅有0行
和1行

之间的差距

# 换行语法
I really like using Markdown.换行<br>用‘<br'或者直接回车，比如
这样

# 强调语法
两边**对称**，用两个星号或两个_表示<strong>强调</strong>最好用星号,_不兼容。

一个星号或_表示斜体，也还是用***星号***比较好<br>_**s**_,__*s*__,星号和_混写也还好,但是混用要空格或加标点似乎是。

# 引用语法
'>+content'代表引用，段落和段落之间加>可以引用在同一个框内。
>例如，
>我这样子多打几个字，让它换到下一行看看会不会把空行给填充起来，看来是不行，那我换行试试看。比如说这样子<br>在
>
>不行了

> Dorothy followed her through many of the beautiful rooms in her castle. so it还是不能填充空行。 
>
> The Witch bade her clean the pots and kettles and sweep the floor and keep the fire fed with wood.

>> 引用里也可以引用,加上>就好了
>> 我是引用里的引用

# 列表语法
使用**数字**加**英文句点**，不必按顺序标注数字，例如，你可以1.sth, 1.sth, 7.sth;渲染出来是按顺序的
1. th
4. sfdah
5. 你好
   1. 你好啊
   2. 我好啊
   3. 他好啊
2. 数据
   
# 代码语法
用'`'来渲染代码，如

`print("hello world!")`<br>
用两个`包含单词 

``Use `code` in your Markdown file.``

    &lt;html>
      &lt;head>
      &lt;/head>
    &lt;/html>
缩进***四个***空格或一个tab形成代码块

# 分隔线语法
三个-或*或_可以形成***分隔线***空格
分隔线上下都写空行

Try to put a blank line before...

---

...and after a horizontal rule.<br>
Without blank lines, this would be a heading.
---
Don't do this!

# 链接语法

## **使用'[title]'+'(address)'形成链接**
这是一个链接 [Markdown语法](https://markdown.com.cn)。
这是一个链接 [Markdown语法]: https://markdown.com.cn。

## **网址后面加个空格可以补充光标悬停时显示的文本,文本要加引号**，如
这是一个链接 [Markdown语法](https://markdown.com.cn '最好的教程')。
这是一个链接 [Markdown语法](https://markdown.com.cn "最好的markdown教程")。

## 用<>把url或Email地址包括
如
<https://markdown.com.cn>
<email@example.com>

链接可与上述语法混用，如
I love supporting the **[EFF](https://eff.org)**.
This is the *[Markdown Guide](https://www.markdownguide.org)*.
See the section on [`code`](#code).

[link](https://www.example.com/my%20great%20page)

**'%20'**代表空格
似乎不行，没咋看懂引用链接
[hobbit-hole] [1]
[hobbit-hole] [1]

[1] https://en.wikipedia.org/wiki/Hobbit#Lifestyle
[1]: https://en.wikipedia.org/wiki/Hobbit#Lifestyle "Hobbit lifestyles"

# 插入图片

使用`![图片alt](图片链接 "图片title")`
如 ![march 7th](ComfyUI_00001_.png 'a image about march7')

[![沙漠中的岩石图片](/assets/img/shiprock.jpg "Shiprock")](https://markdown.com.cn)

![march 7th](D:\summerStudy\ComfyUI_00001_.png 'a image about march7')

[]里面是图片加载不出时的文本


 <font size=5>使用git<font>
<font face="逐浪新宋">我是逐浪新宋</font>
<font face="逐浪圆体">我是逐浪圆体</font>
<font face="逐浪花体">我是逐浪花体</font>
<font face="逐浪像素字">我是逐浪像素字</font>
<font face="逐浪立楷">我是逐浪立楷</font>
<font color=red>我是红色</font>
<font color=#008000>我是绿色</font>
<font color=yellow>我是黄色</font>
<font color=Blue>我是蓝色</font>
<font color= #871F78>我是紫色</font>
<font color= #DCDCDC>我是浅灰色</font>
<font size=5>我是尺寸</font>
<font size=10>我是尺寸</font>
<font face="逐浪立楷" color=green size=10>我是逐浪立楷，绿色，尺寸为5</font>
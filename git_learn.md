# Git笔记
<font size=6>使用<font size=8>***git init***</font>来初始化仓库</font>
<font size=6>使用<font size=8>***git status***</font>来获取文件的状态，<font size=8>***git status -s*** or ***git status --short***</font>获取简短信息，有两列，左边暂存区，右边工作区</font>
<font size=6>使用<font size=8>***git add***</font>将内容添加到下一次提交中（暂存区），可用来追踪新文件</font>

若将文件修改但未提交，那么在暂存区和未暂存区都有记录，一个是旧的，一个是新的

<font size=6>使用<font size=8>***cat .gitignore***</font>来忽略一些文件，例如</font>


    $ cat .gitignore
    * .[oa]  #忽略所有以.a、.o结尾文件
    * ~    # 忽略所有以 ~ 结尾的文件

<font size=6>使用<font size=8>***git diff***</font>来输出修改和暂存文件的差异（增加，减少）了什么</font>
<font size=6>使用<font size=8>***git diff --staged***</font>来输出暂存和上次提交的差异（增加，减少）了什么</font>

<font size=6>使用<font size=8>***git commit***</font>来提交变更（不推荐，麻烦），没有提交信息将会取消提交</font>

<font size=6>使用<font size=8>***git commit -m ""***</font>来提交变更，引号内为提交信息</font>

<font size=6>使用<font size=8>***git commit -a -m ""***</font>来跳过暂存区提交</font>

<font size=6>使用<font size=8>***git rm***</font>来删除文件（更改且未add的不行）括号情况加上<font size=8>***-f***</font></font>

<font size=6>使用<font size=8>***git rm --cached <file>***</font>来移除暂存区的文件，而保留在工作区</font>

<font size=6>使用<font size=8>***git mv file_from file_to***</font>来重命名文件</font>
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

<font size=6>使用<font size=8>***git rm***</font>来删除文件（暂存区有记录或工作区和head不一致）括号情况加上<font size=8>***-f***</font></font>

<font size=6>使用<font size=8>***git rm --cached <file>***</font>来移除暂存区的文件，而保留在工作区</font>

<font size=6>使用<font size=8>***git mv file_from file_to***</font>来重命名文件</font>

<font size=6>使用<font size=8>***git log***</font>来详细输出记录，可选参数如下</font>

|parameter|function|
|---------|--------|
|-p|显示差异|
|-n|显示最近n次的提交|
|--state|显示改动文件列表，个数，增减多少行|
|--pretty=oneline|一行输出信息|
|--pretty=format:""|格式化输出|
|--since=""|时间之后|
|--until=""|时间之前|
|--author|作者名字|
|-S(name)|输出包含增减指定字符串(name)的提交|

<font size=6>使用<font size=8>***git commit --amend***</font>来撤销操作，重新提交</font>

<font size=6>使用<font size=8>***git reset HEAD (file)***</font>来撤销已暂存的文件</font>

<font size=6>使用<font size=8>***git checkout -- (file)***</font>来撤销修改</font>

<font size=6>使用<font size=8>***git remote add [shortname] [url]***</font>来添加远程仓库，后面使用shortname代替url</font>

<font size=6>使用<font size=8>***git fetch (remote name)***</font>来获取远程仓库的更新，（不会合并）克隆仓库时自动获取地址并命名为origin</font>

<font size=6>使用<font size=8>***git pull (remote name)***</font>来获取远端数据并合并到本地动作目录</font>

<font size=6>使用<font size=8>***git push (remote name) (branch name)***</font>来上传本地数据到远程仓库（默认origin master）</font>

<font size=6>使用<font size=8>***git remote show (remote name)***</font>来查看远程仓库信息</font>

<font size=6>使用<font size=8>***git remote -v***</font>来查看远程仓库信息</font>

<font size=6>使用<font size=8>***git remote rename (remote name) (new name)***</font>来重命名远程仓库</font>

<font size=6>使用<font size=8>***git remote rm (remote name)***</font>来删除远程仓库</font>
                        
|git tag|function|
|-------|-------|
|none|show all tags|
|-l "tagname"|show tags with tagname|
|-a "tagname"|create new tag|
|-d "tagname"|delete tag|
|-m "message"|add message to tag|
|tagname|create tag|
|-a tagname 部分校验和|add tag with partial checksum|
|git show tagname|show tag information|
|git push origin tagname|push tag to remote repository|
|git push origin --tags|push all tags to remote repository|

<font size=6>使用<font size=8>***git branch (branch name)***</font>来创建新分支</font>


<font size=6>使用<font size=8>***git checkout (branch name)***</font>来切换分支</font>

<font size=6>使用<font size=8>***git checkout -b (branch name)***</font>来创建新分支并切换</font>

<font size=6>使用<font size=8>***git merge (branch name)***</font>来合并分支到当前分支 </font>

<font size=6>使用<font size=8>***git remote add origin `git@github.com:repo.git`***</font>来使用ssh链接远程仓库</font>

<font size=6>使用<font size=8>***git push -u origin master***</font>来建立上游分支master并推送 </font>

<font size=6>使用<font size=8>***git restore filename***</font>来放弃工作区对某一文件的修改 </font>

<font size=6>使用<font size=8>***git restore .***</font>来放弃整个工作区 </font>

<font size=6>使用<font size=8>***git restore --staged filename***</font>来撤出暂存区 </font>

<font size=6>使用<font size=8>***git restore --staged --worktreee filename***</font>来放弃工作区和暂存区提交 </font>

<font size=6>使用<font size=8>***git reset --soft HEAD~1*** 或 ***commit_id***</font>来撤销1次提交或回到指定提交 </font>

<font size=6>使用<font size=8>***git reset --mixed***</font>来撤销提交和暂存区文件，且是reset命令默认的参数 </font>

<font size=6>使用<font size=8>***git reset --hard***</font>来回退上一个提交，丢弃工作区和暂存区</font>

|git|<font size=6>revert|
|---|-------------------|
|参数|作用|
|git revert commit|还原C|
|git revert HEAD~2||
|--no-commit|反向提交只暂存不自动提交|
|--edit|修改默认提交信息|
|--abort|冲突时放弃整个revert|

# git ignore注释要单独写一行，不然不会生效。

| 场景             | 推荐命令                                                    | 理由                     |
| -------------- | ------------------------------------------------------- | ---------------------- |
| 撤销 `git add`   | `git restore --staged <file>` 或 `git reset HEAD <file>` | 不改历史，只动暂存区             |
| 工作区改坏了，想还原     | `git restore <file>`                                    | 不动 HEAD，只恢复工作文件        |
| 提交信息写错，想重提     | `git reset --soft HEAD~1`                               | 提交变回暂存，改完再 commit      |
| 最近几次提交想扔掉（未推送） | `git reset --hard <commit>`                             | 三棵树一起回退，**慎用**         |
| 已推送的坏提交        | `git revert <commit>`                                   | 新建反向提交，**不改历史**，适合公共分支 |

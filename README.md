<<<<<<< HEAD
# PROJECT INTRODUCTION
Since a long time(over 3 years), I eager to have the experience of playing a special game in English. Since I am a Chinese, I have experienced playing Chinese Words Link. That is a traditional Chinese game, too. There is a simple overview  of that: one of some people (just 2 or more than 2) starts to tell a Chinese term (double words or triple words or quadra words), the next people has to tell a different Chinese term. The second Chinese term must begin with the last word in the Chinese term the last people told. And so on for other people remainding.
That's a long link of Chinese terms.

# What create based on
1. Based on C# and .NET 4.5
2. Based on Microsoft Office Excel 16

# How to develop it
1. A well-collected English Words Lib in excel file.
2. In order to speed up looking up a word in lib, I divide it into 26*26 sub file.
3. According to the First one character in most words, I divide them into directories named from 'a' to 'z'.
4. According to the Second one character in all words in all directories named from 'a' to 'z', I divide them into sub-file named from 'a' to 'z'.
5. *But the time costed on looking up a word is still too long.*

# What problems remained still
1. It is a emerency to optimaze the look-up-algorithm.
2. It should be developed based on earlier than Office 2010 to have more aboard usage.

# KEY PROBLEM RECORD
After updating Git from 2.23 to Git 2.31, I found taht the default branch does not name "master" any more,
but "main"; But I did not aware that before committing this Code Project. I used the order below one by one,
1. "git init"
*init the current directory to be a git-management directory*

2. "git add ."
*add the code-files in current directory to a staging area*
*the argument '.' is used to add all files*

3. "git commit -m 'first-commit-player-single-mode-completed'"
*add the code-files in staging area to local repository*

4. "git remote add origin https://github.com/haoyuSun4008/WordSolitaire/.git" 
*create relation between remote repository and the local repository*

5. "git config --global --unset hhtp.proxy"
*cancle the http.proxy, to solve error about Signing Into Git*

6. "git push -u origin master"
*push the code in local repository to remote repository branch named master*
*the argument -u is used to enable 'git push' works as 'git push origin master' after this*

After doing these procedures, I found that there are two branches named 'main' and 'master', and the branch 'main' is marked default, but no pushing files in it, it's a empty branch. But in branch 'master', there is what have been pushed just. So, I looked for some solutions to merge the two branches. Steps are listed below:

1. git checkout main
*After the Update in 2020/10, Git adopts 'main' to be its default branch name but 'master'*
*In more situations, the debug code/project is not a defult branch but some sub-branches. The new code after tests should be merged to a main/default branch*

2. git merge master --allow--unrelated-histories
=======
# PROJECT INTRODUCTION
Since a long time(over 3 years), I eager to have the experience of playing a special game in English. Since I am a Chinese, I have experienced playing Chinese Words Link. That is a traditional Chinese game, too. There is a simple overview  of that: one of some people (just 2 or more than 2) starts to tell a Chinese term (double words or triple words or quadra words), the next people has to tell a different Chinese term. The second Chinese term must begin with the last word in the Chinese term the last people told. And so on for other people remainding.
That's a long link of Chinese terms.

# What create based on
1. Based on C# and .NET 4.5
2. Based on Microsoft Office Excel 16
3. 

# How to develop it
1. A well-collected English Words Lib in excel file.
2. In order to speed up looking up a word in lib, I divide it into 26*26 sub file.
3. According to the First one character in most words, I divide them into directories named from 'a' to 'z'.
4. According to the Second one character in all words in all directories named from 'a' to 'z', I divide them into sub-file named from 'a' to 'z'.
5. *But the time costed on looking up a word is still too long.*

# What problems remained still
1. It is a emerency to optimaze the look-up-algorithm.
2. It should be developed based on earlier than Office 2010 to have more aboard usage.

# KEY PROBLEM RECORD
After updating Git from 2.23 to Git 2.31, I found taht the default branch does not name "master" any more,
but "main"; But I did not aware that before committing this Code Project. I used the order below one by one,
1. "git init"
*init the current directory to be a git-management directory*

2. "git add ."
*add the code-files in current directory to a staging area*
*the argument '.' is used to add all files*

3. "git commit -m 'first-commit-player-single-mode-completed'"
*add the code-files in staging area to local repository*

4. "git remote add origin https://github.com/haoyuSun4008/WordSolitaire/.git" 
*create relation between remote repository and the local repository*

5. "git config --global --unset hhtp.proxy"
*cancle the http.proxy, to solve error about Signing Into Git*

6. "git push -u origin master"
*push the code in local repository to remote repository branch named master*
*the argument -u is used to enable 'git push' works as 'git push origin master' after this*

After doing these procedures, I found that there are two branches named 'main' and 'master', and the branch 'main' is marked default, but no pushing files in it, it's a empty branch. But in branch 'master', there is what have been pushed just. So, I looked for some solutions to merge the two branches. Steps are listed below:

1. git checkout main
*After the Update in 2020/10, Git adopts 'main' to be its default branch name but 'master'*
*In more situations, the debug code/project is not a defult branch but some sub-branches. The new code after tests should be merged to a main/default branch*

2. git merge master --allow--unrelated-histories
>>>>>>> 107fc6e1080282880a252361b30f773edae65d43
*merge branch master to main, and force to complete without caring about unrelated histories problems*
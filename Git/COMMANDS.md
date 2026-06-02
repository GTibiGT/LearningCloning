
Git

Imagine you are writing a novel. Everyday - you make changes to the manuscript. 

What if you want to go back to yesterday's version? Or what on a new chapter without
ruiining the main draft?

This is exactly what GIT does for the code. It is a time machine + parallel universe
machine for file. 


Q1: ----
Ibrahim has a folder with some files. Before git can track anything, Ibrahim
needs to turn ON version control in that folder. what is the command for that?

>>>> git init

This creates a hidden .git folder - the journal. Nothing is tracked yet, but
Git is now watching the folder. 

Q2: ----
Now Ibrahim made some changes to those files, and forgot which files he changed. 
He wants to check which files were updated. What command should he use?

>>>> git status

It is like asking your journal, "what did I edit today that I have not written down yet (written
meaning finally commiting it)?"
Git replies with a list of files that have changed or haven't been recorded yet. These are
called untracked or modified files. 

Q3: ----
Before Ibrahim can save a version, he needs to decide what to include. Git has a special
holding area called the staging aera. This way, if he changed multiple files, let's 
call them A, B, C and only wants to finalize file A. He can pick those files here.

Assuming Ibrahim has index.html, style.css
.git/ is created after git init, and how he only wants to finalize index.html

>>>> git add index.html
This only adds index.html

>>>> git add . 
This adds all changed files

Q4: ----
Ibrahim wants to save the staged snapshot permanently in the Git's history. Every commit
needs a message describing what changed. 

>>>> git commit -m "Add homepage layout"

A commit is permanent, labeled snapshot. You can always return to it. Each commit
gets a unique ID (a hash) like a3f91bc.

Q5: ----
As time passes, Ibrahim makes more commits. Now, he wants to see the full history
of the project. What command does he use?

>>>> git log
>>>> git log --oneline # shorter view

Q6: ----
Ibrahim wants to try a new dark mode design - but doesn't want to break the working site.
What should he do?

>>>> git branch dark-mode
Creates the branch

>>>> git checkout dark-mode
Switches to that branch

>>>> git checkout -b dark-mode
Creates and then checks out the branch. Both the above commands in one

Both the branches are pointing to the same commit - for now. Once Ibrahim starts
commiting on dark-mode, they will diverge. 

Q7: ---- 
The dark mode looks great! Ibrahim wants to bring it back into the main branch. How do we do that?
Let us assume adding and commiting is done.

>>>> git checkout main
>>>> git merge dark-mode

If two branches changed the same line, you get a merge conflict. Git asks you
to decide which version wins.

Q8: ----
So everything is on Ibrahim's laptop. Github is remote - a copy of the repo 
stored online, sharable with teammates. 

Your laptop is your personal notebook. Github is the shared google doc that everyone
can access. 

>>>> git remote add origin https://github.com/Ibrahim/site.git
First created a new repo and got its link. Then connected local machine
with that repo. 

>>>> git push origin main 
Send our commits up to the local repo

>>>> git pull origin main
Get other people's changes

Q9: ----
A new teammate shows up and wants to join the project. They need to download 
the whole repository to their laptop. How will they do it?

>>>> git clone https://github.com/Ibrahim/site.git

This downloads the repo, sets up origin automatically, and checks out the default branch. 
New teammate is now ready to work.




Test questions:

Q1: You edited index.html. You run git status and see it listed as 
modified. What do you do next before committing?

git add index.html

Q2: You built a project locally from scratch and want to push it to a 
brand new empty GitHub repo. What do you need to do first?

git remote add origin


Q3: You just created a new folder with some files. 
What is the very first Git command you run?

git init


Q4: Which command saves your staged changes permanently into Git's history?

git commit -m 'message'

Q5: Your colleague pushed new commits to GitHub. 
You want to get their changes onto your laptop. Which command do you use?

git pull origin main


Q6: You want to try a risky new feature without 
touching the working main branch. What do you do?

git checkout -b name

Q7: You try to merge and Git shows 
conflict markers in style.css. What is the correct sequence to resolve it?

Open the file, edit out the markes, keep the right code and git add and git commit

Q8: You want to see a list of all past commits 
on the current branch. Which command do you use?

git log


Q9: A teammate sends you a zip file. Inside is a .git folder. 
You want to connect it to the existing GitHub repo. What do you run?

git remote add origin url
git push origin main


Q10: The remote has commits you don't have. 
You try git push and it fails. What should you do — and what should you avoid?

git pull first to merge remote changes, then git push



>>>> git pull = git fetch + git merge

git fetch = downloads the remote commits to your machine but does NOT merge them into 
your current branch. Your working code is untouched. You're just grabbing the latest info
to look at it.

When should you use fetch over pull?
- You want to see what teammates pushed before deciding to merge
- You'rre on a sensitive brranch and do not want surprise merges
- You want to compare gitt diff main origin/main after a fetch

In practice, most beginners just use git pull daily. Fetch becomes useful once you're
working in teams and want more control.


Q11: You want to see what your teammate pushed to GitHub before 
deciding whether to merge it into your branch. Which command is safer to use?

git fetch origin


Q12: After running git fetch, 
how do you actually apply the downloaded changes to your branch?

git merge origin/main


Q13: You're mid-way through editing files when you urgently need to 
switch to another branch — but you're not ready to commit. What do you do?

>>>> git stash

This temporarily shelves your uncommited changes so you can switch branches
cleanly. Run git stash pop later to restore them.

Q14: You staged a file with git add but haven't committed yet. 
You change your mind and want to unstage it. Which command works?

>>>> git reset HEAD file.txt 

It removes the files from staging without changing the file itself. The edits stay -
they are no longer queued for the next commit.

Q15: You committed something you shouldn't have. 
You want to create a new commit that undoes that change (without rewriting history). Which command?

>>>> git revert HEAD

This creates a new commit that is the inverse of the last one. History is preserved - safe to 
use on shared branches. 

Q16: You finished working on a feature branch and 
merged it into main. How do you delete the branch you no longer need?

>>>> git branch -d feature-branch

Use -D (uppercase) to force delete an unmerged branch. 










May 18 2026

Q1: git init?
You write this command at the start of a project to create a git folder thats all it does

Q2: If I clone a repo, do I need to git init?

no because it clones the whole repository including .git folder

Q3: What is the purpose of .git folder?

It saves and tracks all the changes in the project

Q4: git status?

git status basically tells you what changes or edits you made in the project. what files have changed. these files are called untracked or modified files. 

Q5: what is git add, and how to use it?

Ibrahim: "git add adds all the files to the .git folder"

Arnav: git add helps us filter which files to commit to git history. We can pick individual files here. 
git add .  ---- adds all files to the staging area
git add index.html ---- only adds index.html to the staging area

Q6: What is staging area?
Buffer zone in git where you prepare changes before officially saving them to git history

Q7: What is git commit, and how to use it (the command itself)?

it saves your staged changes in the git folder, git commit -m "chaging the header in the title"

Q8: What is the difference between git add and git commit?

git add adds files to the staging area and git commit adds them from staging area to github

Q9: git log?

shows the full history of the project

Q10: What is git branch, and how to use the command?

Creates a copy of current folder to test out or change stuff without editing the actual file. git branch dark-mode

Q11: git checkout, and how to use it?

Used to go from one branch to another. git checkout dark-mode

Q12: If you wish to create a new branch, and checkout using one command only - how to do that?

git checkout -b dark-mode # create + switch

Q13: If you like your dark mode changes, and wish to bring them into main branch. Currently you are in dark-mode branch. How do you merge
dark-mode into main? Write all commands necessary.

git checkout main
git merge dark-mode

Q14: When to use "git remote add origin https://github.com/ibrahim/site.git"? Last thing is link to the repo.

Ibrahim: "is used to add a file or folder that is saved in your system or something similar and add it to the repo"

Arnav: This command is used when you did not clone a repo. You created a local project and used git init. In this case, there is no cloud repo saving 
your changes. In that case, you will:
1. Create a new empty repo, for which the link we assume to be https://github.com/ibrahim/site.git
2. On local machine, we run the command git remote add origin https://github.com/ibrahim/site.git. It helps connect our local changes to the repo.
3. git push origin main, this sends the changes up to the cloud repo

Q15: What is git clone?

creates a copy of a existing project from the cloud, that maybe someone else made so that you can edit and use it on your machine

git status
git add .
git commit -m "made second commit"
git push




first we wish to create a new branch, called testbranch and we wish to be inside that branch.
We want to edit the commit message there to say third commit in readme. 
Then we wish to push those changes to this branch on the cloud.

git branch "name"				expect this to create a branch
git checkout "name"			expect this to take me to the branch

make the changes in the readme file by opening it in the termianl using:
notepad READEME.md

git status
git add .
git commit -m "my third commit"
git push



use the github commands we learned in the terminal to merge the changes in the 
test_branch with main

git checkout main					takes us back to the main branch
git merge test_branch			merges the other branch to main
git push



create a new branch called test_branch2. edit the readme to say fourth push. the push the changes for the branch to github. 
DO NOT MERGE THE CHANGES WITH MAIN BRANCH HERE.

git branch "name"
git checkout "name"

notepad README.md 			make the changes

git add .
git commit -m "fourth commit"
git push

git branch fifth_branch
git checkout fifth_branch

notepad README.md

git add .
git commit -m "fifth commit"
git push

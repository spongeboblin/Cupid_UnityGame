# CSCI 526 Mobile Games Development 

**For technical details: https://hackmd.io/@MsMlEAOxRcuOLCwRo2VCyg/BJ9pmyxKr**



[toc]

## Game title 
Cupid

## Gameplay Overview

The player controls Cupid with the ability to shoot love arrows onto characters in scene to make specified characters fall in love with each other.

## Gameplay Mechanics
The core Mechanic is shooting arrows. Players shoot arrows by charging the bow(pushing down and dragging within an area on the left side of the screen) and releasing the arrow (simply letting go of the finger). The arrow will have interaction with characters or items on the map once it hits them.

**Example interactions:**

1. After the arrow hits the first character:
* His/her designated match will be highlighted on the screen.
2. After the the next arrow is shot into another character:
* If the second character is a match to the previous character, these two characters will disappear from the map with an animation. And the corresponding matching score will be added to the total score.
* If the character is not a match to the previous character, the effect of the arrow would be cancled and his/her designated match will be highlighted on the screen. Players have to shoot arrow on both of the couples again.

3. Arrow hits an item:
* The item will be added to the item inventory and then it disappears from the map.


## Win / Lose Conditions

#### Winning one level
The player wins a level when they achieve one of the following conditions within the time limit:
1. Reach the minimum score required to pass the current level. (When time runs out, the system will check if the player reach the minimum score).
2. Successfully pairing all the couples in the map. (The current level will end if the player pairs all the couples. Pairing all the couples guarantees that the player will reach the minimum score, and in general, has a higher score than the minimum score.

#### Winning the overall game
The player finishes all levels in the game map.

#### Losing one level
The player will lose the current level when they satisfy the following condition at the same time:
1. Time runs out.
2. Not reach the minimum score required to pass the current level.

## Level Overview
The goal of each level is to match all couples on the map within a certain amount of time. To unlock the next level however, players are not required to match all couples. It will be unlocked as long as the player reaches the minimum requirement(score) of the current level. The player can replay a level as many times as he/she wants and only the highest score will be recorded.

## Score
The following will be considered as an addition to the score:
* Correctly matched couple
* Time remaining
* Hitting a character
* Matching streak

## Items
The player is able to use the item by tapping on item inventory located on the top-left of the screen.



| Item Image | Item Name | Item Description
| -------- | -------- | -------|
|![](https://i.imgur.com/ga7AUNL.png)| Time Master | Add 30s |
|![](https://i.imgur.com/r7z1Ct2.png) | Star Master | Add 1000 points |
|![](https://i.imgur.com/eSYTPfg.png)| Lightening | Instantly match a couple |
|![](https://i.imgur.com/CH3syFE.png) | Freeze| All couples stop moving | 



## Scene Transition Diagram
![](https://i.imgur.com/rRWVzFy.png)

## Game Overview Flowchart Description
When players start the app, they can click anywhere to enter the game on the menu page. Then, they need to choose a stage to start playing the game on the stage map page. After the stage is over, three kinds of dialogs will be shown as the following.

If pass a stage, a dialog will show “Stage Clear”. The player can go back to the stage map by clicking “Back to Map” button or continue the game by clicking “Next Stage” button. 

If a stage is failed, a dialog will show “Stage Failed”. The player can go back to stage map by clicking “Back to Map” button or retry the game by clicking “Retry” button. 

If the player passes all stages, a dialog will show “Congratulations! You’ve cleared all stages!”. The player can go back to stage map by clicking “Back to Map” button.

## Screen Mock
![](https://i.imgur.com/lcmKnnm.png)

![](https://i.imgur.com/fINIudY.png)

![](https://i.imgur.com/V9D5jos.png)

## Terminologies


| Name | Description | 
| -------- | -------- | 
| Cupid | It is the main character players are acting. The responsibility of a Cupid is to pair targeted characters (lovers) using its love arrows, which is the goal of the game.| 
| Love Arrow | It is an arrow with a red heart at the end of it. It is the tool Cupid used to pair targeted characters (lovers). Once two targeted characters (lovers) are both hit by the love arrows, they would become a couple and disappear from the screen. |
|Targeted lovers | They are characters that wait to be paired by Cupid. Cupid uses the love arrows to hit the targeted lovers to make them become a pair of couple.|
|Stage Name| - |
|Score|There are two numbers on the top of the screen, one is the minimum score required for the player to succeed in this round, and the other one is the current score the player has achieved. Hit a pair of targeted lovers and get required items would generate more score.|
|Time Remaining |There is a time limit for each round of the game. And the Time Remaining shows the time left for the player to shoot the targeted characters.|
|Stage Map| At the beginning of the game, there is a Stage Map page showing all of the stages the players could choose from. And the players could only finish all of the previous stages before they could move to the next stage. But they could always play the previous stages as they like. |
|Menu/Setting |At each stage, there is a Menu/Setting button at the top of the screen which players could choose their options such as start the next stage, reply the current stage, etc.|
|Item |There are items such as golden coins, …., which would help players to shoot more targeted characters with more accuracy and would also generate more scores for the player.|
|Arrow Switch| There are two options for Cupid, one is the loving arrow with red heart, and the other one is the arrow with black heart. Red one is used to pair targeted characters, and the black one is to separate two paired characters which have been paired by mistake.|
|Mark| It is an indicator on the top of a character, which shows that the character is the one to shoot.|


## Github Tutorial

1. Before first clone remote repo to your computer, use command line to enter into the directory that you want to save your local repo.

2. Clone remote repo: `git clone [your remote repo HTTPS link]`

3. Enter into the local repo directory using command line: `cd Cupid-Project`

4. Create a new branch to make change: `git checkout -b [your branch name]`

5. After modifying the project, check your modification: `git status`

6. After modifying the project, check your branch (Please make sure you are not on master!!!): `git branch`

7. Commit your modification, you may use one of git statements from the following: 
`git commit -am "your message about this change"`

**OR**

```
git add .
git commit -m "your message about this change"
```
8. Push your modification from your local branch to your remote branch: 
`git push origin [your local branch name]`

9. If this is the first time to push on this branch, copy the url link that is given on the command line after the push statement. Open the website, paste the link, click pull request button.

10. Wait for reviewing and merge the code.

11. If you have not updated for a long time, before you push, you can:
* Switch to your local master: `git checkout master`
* Pull the updatest remote repo to your local repo: `git pull / git pull origin`
* Switch back to your branch: `git checkout [your branch name]`
* Merge the updated master to your branch: `git merge master`

12. Important note!!!!!!!! Every new change needs to be made on a new branch!!!!! Do not do anything on master!!!!!!

## Team Members


| English Name | Chinese Name | USC email |
| -------- | -------- | -------- |
|Kai-Xing Wang|王楷兴|kaixingw@usc.edu|
|Xue-Ying Bai|白雪莹|xueyingb@usc.edu|
|Chia-Ming Hu(Michael)|胡家銘|chiaminh@usc.edu|
|Zhao-Qi Wang|王昭淇|zhaoqiwa@usc.edu|
|Jiawen Hao|郝家文|jiawenha@usc.edu|
|Yifu Wang|王逸夫|yifuwang@usc.edu|
|Qing Wang|王晴|wang513@usc.edu|
|Xinyi Lin|林昕艺|lin757@usc.edu|


## Task Tracer Sheet
https://docs.google.com/spreadsheets/d/1lpn6FWwkuRfrGCmc2BvNjYp7pCRQwdtj9iJxXFZ8cTM/edit?usp=sharing

https://docs.google.com/spreadsheets/d/1Rd2dWzyBcsJncXmHwzip4715Nf4__0zgOeEk2pu18g8/edit#gid=116940591

## Asset Resources
[BBC Sound Effects](http://bbcsfx.acropolis.org.uk/)



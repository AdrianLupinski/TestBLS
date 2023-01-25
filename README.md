# Test-BLS
I use only assets that you gave me, I only add TMP package. This project took me almost 6 hours, but I was tired because I was working the morning shift. 
I will now explain why I chose these kind of solutions.
1. For Player I creade 3 scripts. One is for movement, another is weapon and last is for Health. I want to keep every funcion of player behavior seperate.
2. Enemy when it hit by a object with tag "weapon" add score by event. Diffrent enemy can give diffrent amount of score (now for every enemy is 1).
3. EnemySpawnMenager instantiate gameobjects. It hold placetospawn enemys and enemys prefab (now i add only one with variants). Also we can change how offen new wave with enemys will instantiate. Aslo as you requested it spawn random amount of enemys (between 2 and 5).
4. For background i create plane and put sprite indide. I change backgrond sprite warp for repeat and now i only move it in plane. For me that was the easiest way to do it.
5. Bestscore i keep in PlayerPref, that was for me aslo the easiet way to do it.
6. Last score i keep in object with dontDestroydOnLoad. Then when scene is load i call event and update lastscoretext.

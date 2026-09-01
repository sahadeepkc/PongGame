Name: Sahadeep Kc
CS-3383 Software Engineering
Assignment-1

PongGame

A 2-player Pong game made in Unity. 

Game Instructions:
Left paddle: W/S. 
Right paddle: Up/Down arrows.
Press Esc to pause and pull up the controls/scoring info, press it again to resume.


JUST WANT TO PLAY?

There's no standalone .exe yet, so you'll need to run it through Unity.

1. Get Unity Hub from unity.com/download and install it.
2. After Unity is downloaded, install Unity 6.3 LTS (6000.3.23f1) version of Unity.
3. Download the zip file from: https://github.com/sahadeepkc/PongGame. Click on Code and then on download ZIP.
4. In Unity Hub: Projects > Add > Add project from disk, and point it at the unzipped folder. Give it a minute to import everything the first time.
5. Once it opens, go to Assets/Scenes in the bottom panel and double-click Pong.unity.
6. Hit the Play button up top. That's it.


JOINING THE TEAM?

Unity version: 6000.3.23f1

Getting set up:
1. Install Git if you don't have it (git-scm.com).
2. Clone it: git clone https://github.com/sahadeepkc/PongGame.git
3. Follow steps 1-5 above to get Unity Hub, the right Editor version, and the project open.

What's where:
- Assets/Scripts/Ball.cs — ball movement and reset after a score
- Assets/Scripts/Paddle.cs — paddle input/movement
- Assets/Scripts/GameManager.cs — score tracking, Esc pause/help
- Assets/Scripts/ScoreZone.cs + ScoreText.cs — score triggers and the on-screen numbers
- Assets/Scenes/Pong.unity — the game scene
- Assets/Prefabs — paddle/wall/score-text prefabs

Making changes:
Edit scripts in whatever code editor you've got hooked up to Unity (double-click a .cs file to open it). Edit the scene/objects directly in the Unity Editor. Test with Play before you commit, anything changed while in Play mode doesn't actually save.

Building an executable:
File > Build Settings > add the Pong scene if it's not listed > pick your platform > Build.

Pushing changes:
git add .
git commit -m "what you changed"
git push

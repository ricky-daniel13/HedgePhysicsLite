# HedgePhysicsLite
Simplified version of "Hedge Physics" originally by LakeFeperd and Damizean
###### Description:
HedgePhysics is a debloated and simplified version of the "Hedge Physics" engine by LakeFeperd and Damizean. This version of the engine is constrained to 5 basic prefabs (Unity objects) and strictly only gameplay and movement scripts, which have been slightly revised to conform a bit better to Unity best practices. 

The original source code of the engine is provided as-is, containing lots of left overs from seemingly previous iterations, its tied to various old and deprecated Unity plugins and features, and its tied by a lot of hard to decipher dependencies.
All of this is perfectly aceptable for a free engine made in someone else's free time. However this issues made the engine hard to understand and learn from. 

As they are not a lot of resources for learning Sonic-style physics in 3D, I decided to take on the task of simplifying the engine to its most bare components to make this a resource to learn and to built from.

![Screenshot of the engine in-editor](Screenshot.png?raw=true)

###### Features:
- Character controller with different actions: Jumping, Rolling, and Crouching
- Slightly improved state machine from the original Hedge Physics
- Four example gameplay objects: Spring, Dash Panel, Hazard, and Enemy
- A test stage and a minimal ammount of test assets
- Exactly nothing else.

###### How to Use:
Download Unity and clone the repository. This repository contains a few LFS files (the test assets).
It should work with any version of Unity, as its not tied to any specific editor function or plugin/package.

###### Ideas for you:
- Improve the rolling state
- Add Enemy AI
- Add an animated model, and code it's animator
- Code a better state machine

This simplified engine is made with people slightly experienced in coding and Unity in mind, who are looking into understanding Sonic physics and don't need all the extra tools. These ideas are not requests, just things you can do to expand the engine for you and your needs ;-)


###### Original description (by LakeFeperd)
##### Hedge Physics
Extracted from [SonicRetro](https://forums.sonicretro.org/index.php?threads/1-0-final-hedge-physics-3d-sonic-engine-on-unity.36171/)
###### Description:
> HedgePhysics is a open source 3D Sonic engine made in Unity made by Me with some coding help from Damizean.
###### Licence:
You're allowed to use this for anything that you want, including commercial projects. Credit Me and Damizean if you whish.
###### How to Use:
[Get Unity](https://unity3d.com/get-unity/download/archive), [Learn Unity](https://unity3d.com/learn/tutorials) and Open it in Unity.
To make levels, [Get Blender](https://www.blender.org/download/) and [Learn Blender](https://www.youtube.com/playlist?list=PLjEaoINr3zgHs8uzT3yqe4iHGfkCmMJ0P).
###### "I need help":
Feel free to ask any advice on my discord server: https://discord.gg/fR2mmSn
###### Why did I make this:
Fore the future. I need a good 3D general character controller, and my frustration with the fact I can't find a good one lead me to this. I did take a break from working on Spark to make this, as I felt like I needed to after working on that game for months. Hopefully it will be worth it.
###### Links:
\[1.0\] \[Made using unity 5.6.0f3\]
\[[Playable .exe](https://drive.google.com/uc?id=0Bw7vgPrOLeTHX24xT1hySWZwQUk&export=download)\]
\[[Source code v1.0](https://drive.google.com/uc?id=0Bw7vgPrOLeTHUHpFRVJKMmtkeFU&export=download)\]

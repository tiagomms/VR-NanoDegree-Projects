# A Maze Starter VR Project for Android

This project is part of [Udacity](https://www.udacity.com "Udacity - Be in demand")'s [VR Developer Nanodegree](https://www.udacity.com/course/vr-developer-nanodegree--nd017). 

Deploy it on your Android and enjoy!

## What did I learn?
This project is focused on learning to code the scripts that bring everything to life. Skills include:

- Creating new C# scripts in Unity
- Attaching scripts to objects
- Using the built-in Monobehaviour methods
- Triggers and Gaze Based Interaction
- Creating, moving and animating objects procedurally
- Familiarization with the Unity documentation
- Scripting Dynamic UI Objects
- Debugging
- The Unity Event System
- Managing and Reloading scenes
- Controlling particle systems
- Create an Audio Clip and playing sounds
- Use of the Waypoint Navigation System
- Profiling scenes for performance

## Project Perks
- Special animations while picking coins and the key to unlock the door
- Bonus: Sounds on temple Door when it is locked or it is opening; the Key to open the temple is floating and the coins rotate in a cool manner.

## Udacity questions
### How long it took to do this project?
1 day.

### One thing I liked this project
I liked integrating script with the objects on Unity.

### One thing that was particularly challenging about the project
I had this really weird bug ***’UnassignedReferenceException: The variable has not been assigned’*** on the door for a very long time. I had never seen it before. First I had duplicated the door game object to act as decorative entrance doors for the maze, and they had the script without variables assigned. However, the bug remained when triggering events. Few hours later, I realised the object on the event trigger was an *old Door game object* -  that was not updated. When I changed, everything started working perfectly.


## Versions
- Unity 2017.1.0p4
- GVR Unity SDK v1.70.0

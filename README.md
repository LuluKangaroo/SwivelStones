# SwivelStones
CSCI 4448

Dr. Montgomery

4/26/19

Match-3 PC game by Lu Liu, Jacob Berman, Josef Los, and Hongyi Chen 

## Project Overview
In this game the player will attempt match as many stones as possible before running out of matches. Afterwards the number of stones matched will be recorded in a high score system. You can compete with your friends to try and be at the top of the leader board. 

## Files Included
All of the game files we wrote will be included in the assets folder.

* The Graphics folder contains all the graphics for our game objects
* The Scripts folder contains all of the scripts that we attatch to those objects. These files contain the classes we wrote and their associated methods
* The scenes folder contains all of the scenes for the different screens in our game. All of these are linked together to create the menus
* The Resources folder contains our prefabs which are instantiated during the runtime of the game. 

The most important of these is the scripts folder as this contains all of our code for the scripts in the game. 
 * Gem.cs: Contains the gem class which manages each of the individual gems that the game spawns. 
 * Main.cs: Contains the main class which acts as the game manager and keeps track of the grid of gems and each gem's movement, as well as checking for matches
 * Timer.cs: Contains the Timer class which was initially slotted to have methods and information to keep track of game time, but is instead used to keep track of score.
 * NewHighScore.cs: Contains the NewHighScore class which implements the screen to add a new highscore
 * HighScore.cs: Contains the Highscore class which contains information pertaining to each highscore displayed on leaderboard
 * Leaderboard.cs: Contains the Leaderboard class which is used to organize and display the scores leaderboard

## Installing and executing
To Install and run the game follow these steps (NOTE: This installation only works for current versions of Windows)

1. Download the repository as a zip file
2. Once installed, extract the file to a destination on your computer
3. Navigate through the files to the SwivelStones.exe icon and run it
4. Select graphical settings and press play to play the game

## Controls
The majority of the game is controlled using the mouse. You use the mouse to navigate the menus, as well as play the game. When in game, you can click to adjacent gems to swap their positions. If this creates a match, then the game will clear these gems and add points to your score. To leave the game, press the escape button. 

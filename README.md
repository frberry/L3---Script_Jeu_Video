# L2 // Projet Jeu Video (Scripts)
The different scripts of my video game :

# MenuScript.cs :

This script allows to manage the menu and the scene management from it.
If we click on "jouer" in the menu, then the "name" item will take the name of the scene with the different levels of play. If we click on "quitter", then the function "Quit()" will start and we quit the game.

## Monstre.cs :

This script includes all the programs related to the monster and its behavior in game.
First of all, we define the player's capsule in relation to the monster.
Then the distance at which the monster will start to run towards the player: MobDistanceRun.

OnCollisionEnter function : This function will start when the monster hitbox will contact the collision capsule around the player, which we defined in this script as "Player". When the monster contacts the collision capsule, we start the Jumpscare / End of game scene.

Start function : It's a function that will define the basic properties of the monster, so first of all its basic speed, and its possible acceleration if it meets the player. We also have the loading of its animation directly managed from Unity and to finish the variable Mob, which corresponds to the places where the monster can pass (the predefined paths of passage).

Update function : First of all, we will check the distance between the monster and the player each time the game will update. Then we have two if-tests, which will switch from one to the other as long as the player is not in the monster's radius, which will allow the monster to move randomly on the map following the different predefined paths it can go through. As soon as the distance between the player and the monster is small enough, the monster will move towards the character's capsule with increasing speed, trying to collide with it.

MusicController.cs :

This is a script that already existed in unity and that we modified to include the possibility to pause the music and restart it by pressing space. The game we created is a game in which the sound of the monster is very important to locate where it is in relation to our character, so we thought of adding in our update function a possibility to pause the background music by pressing space.

NbObjets.cs :

The script "NbObjets" acts as a counter which will be used in the function "ObjetsPrendre" which will allow us to know the number of objects that the player has collected.

ObjetsPrendre.cs :

This script is called each time an object is picked up and contains a variable "val" which will have a value of 7 and will decrement by 1 each time an object is picked up in the game. To pick up an object, we have a collision function, so each time the player's capsule will collide with the hitbox of an object to pick up, it will disappear and val will decrement thanks to the "NbObjects" method. Once val reaches the value 0, a message will be displayed on the player's screen to find the exit, which once reached will make him win if the game timer is not yet at 0.

The script works in such a way that the value "val" will be 7 all along the game, but with each object picked up, "NbObject" will increase and with each call of "TakeObject", we will subtract the number of objects to our value, and once the subtraction is equal to 0, we can finish the game.

PasseGameOver.cs : 

This script is launched if you didn't get all of the object in the given time and it allows you to switch from the gameOver scene to the menu by pressing the space key.

PasseGameOverPerdu.cs:

This script is launched only if you lose by being caught by the monster and allows you to switch from the gameOver scene to the menu by pressing the space key. The difference between this script and the last one is that this script forces the player to wait 3 seconds before pressing space before going to the menu scene to "force" the player to have the jumscare.

Sortie.cs :

This script is launched if the player collides with the hitbox of the exit door. If the player has not picked up all the objects, the number of missing objects is displayed on the screen. If the player has picked up all the objects and collides with the exit door, then the script starts the end of game cinematic.

TimerCountdown.cs :

This script corresponds to the game timer, which is set to 1 minute and 30 seconds at the beginning of the game and is displayed on the player's screen. Every second, the timer is decremented and displays the remaining time of the player. Once it reaches 0, the gameOver scene starts automatically.


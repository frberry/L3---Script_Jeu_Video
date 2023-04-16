# L2 // Projet Jeu Video (Scripts)
The different scripts of my video game :

MenuScript.cs :

This script allows to manage the menu and the scene management from it.
If we click on "jouer" in the menu, then the "name" item will take the name of the scene with the different levels of play. If we click on "quitter", then the function "Quit()" will start and we quit the game.

Monstre.cs :

This script includes all the programs related to the monster and its behavior in game.
First of all, we define the player's capsule in relation to the monster.
Then the distance at which the monster will start to run towards the player: MobDistanceRun.

OnCollisionEnter function : This function will start when the monster hitbox will contact the collision capsule around the player, which we defined in this script as "Player". When the monster contacts the collision capsule, we start the Jumpscare / End of game scene.

Start function : It's a function that will define the basic properties of the monster, so first of all its basic speed, and its possible acceleration if it meets the player. We also have the loading of its animation directly managed from Unity and to finish the variable Mob, which corresponds to the places where the monster can pass (the predefined paths of passage).

Update function : First of all, we will check the distance between the monster and the player each time the game will update. Then we have two if-tests, which will switch from one to the other as long as the player is not in the monster's radius, which will allow the monster to move randomly on the map following the different predefined paths it can go through. As soon as the distance between the player and the monster is small enough, the monster will move towards the character's capsule with increasing speed, trying to collide with it.

MusicController.cs :

NbObjets.cs :

ObjetsPrendre.cs :

PasseGameOver.cs : 

PasseGameOverPerdu.cs:

Sortie.cs :

TimerCountdown.cs :

using UnityEngine;
using System.Collections;

namespace Completed
{	
	public class Loader : MonoBehaviour 
	{
		public GameObject gameManager;			//GameManager prefab to instantiate.
		public GameObject soundManager;         //SoundManager prefab to instantiate.
        public GameObject game;                 // game itself
        public GameObject startScreen;          // start screen
        public GameObject player;               // player variable
        public GameObject mainCamera;           // main camera
        static bool isInGame = false;           // boolean to check if the player is in game or not.
        // when the button is clicked, check if the player is ingame or not
        public void onClick()
        {
            // if the player is not ingame, run the startgame function
            if(!isInGame)
            {
                startGame();
            }
        }
       // take the parameter level and load the game with that level
        public void OnLevelWasLoaded(int level)
        {
            if (isInGame)
            {
                startGame();
            }
        }
        // start game function
        public void startGame()
        {
            mainCamera.SetActive(false);    // disable the main camera
            player.SetActive(true);         // activate the player (and therefore the camera that is the child of the player)
            game.SetActive(true);           // activate the game
            startScreen.SetActive(false);   // disable the start screen
            isInGame = true;                // set the isingame boolean to true
            spawnLevel();                   // run the spawnlevel function
        }

        void spawnLevel()
        {
            //Check if a GameManager has already been assigned to static variable GameManager.instance or if it's still null
            if (GameManager.instance == null)

                //Instantiate gameManager prefab
                Instantiate(gameManager);

            //Check if a SoundManager has already been assigned to static variable GameManager.instance or if it's still null
            if (SoundManager.instance == null)

                //Instantiate SoundManager prefab
                Instantiate(soundManager);
        }
	}
}
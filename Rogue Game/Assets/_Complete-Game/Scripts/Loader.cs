﻿using UnityEngine;
using System.Collections;

namespace Completed
{	
	public class Loader : MonoBehaviour 
	{
		public GameObject gameManager;			//GameManager prefab to instantiate.
		public GameObject soundManager;         //SoundManager prefab to instantiate.
        public GameObject game;                 // game itself
        public GameObject startScreen;          // start screen
        public GameObject player;
        static bool isInGame = false;           // boolean to check if the player is in game or not.

        public void onClick()
        {
            if(!isInGame)
            {
                startGame();
            }
        }

        public void OnLevelWasLoaded(int level)
        {
            if (isInGame)
            {
                startGame();
            }
        }

        public void startGame()
        {
            player.SetActive(true);
            game.SetActive(true);
            startScreen.SetActive(false);
            isInGame = true;
            spawnLevel();
            Debug.Log("game started!");
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
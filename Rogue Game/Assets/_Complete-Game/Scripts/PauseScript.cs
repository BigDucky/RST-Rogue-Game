using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


namespace Completed
{
    public class PauseScript : MonoBehaviour
    {
        
        public static bool isPause = false; // boolean for usage later to check if the game is paused
        public GameObject mainUI;           // main user interface
        public GameObject pauseMenuUI;      // pause menu user interface
        public GameObject startMenuUI;      // start menu user interface
        public GameObject actualLevel;      // the level itself
        public Button pauseButton;          // pause button on the top right corner
        // if the player presse escape, check if the game is paused
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                // if the game is paused, run the resume function
                if (isPause)
                {
                    Resume();
                    return;
                }
                // if the game is not paused, run the pause function
                else
                {
                    Pause();
                    return;
                }

            }
        }
        /*
        public void RestartGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            startMenuUI.SetActive(true);
            mainUI.SetActive(false);
            actualLevel.SetActive(false);            
        }
        */
        // if the player clicks the button
        public void OnClick()
        {
            // if the game is paused, run the resume function
            if (isPause)
            {
                Resume();
            }
            // if the game is not paused, run the pause function
            else
            {
                Pause();
            }
        }
        // deactivate the pause menu UI, activate the main UI and set the timescale to normal speed, and set ispause to false
        public void Resume()
        {
            pauseMenuUI.SetActive(false);
            mainUI.SetActive(true);
            Time.timeScale = 1f;
            isPause = false;
        }
        // activate the pause menu UI, activate the main UI, pause the game with timescale, and set ispause to true.
        void Pause()
        {
            mainUI.SetActive(false);
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            isPause = true;
        }
    }
}
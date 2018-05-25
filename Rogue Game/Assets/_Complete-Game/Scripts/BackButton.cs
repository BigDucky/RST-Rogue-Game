using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour {

    // variables for the options menu, the main screen that is opend and a boolean to check if you are in the options menu or not
	public GameObject optionsMenu;
	public GameObject mainScreen;
	public static bool isOptionsMenu = false; 
    // function that checks if you are in options already when you click the button
	public void onClick()
	{ // if optionsmenu is on, close options
		if (isOptionsMenu)
		{
			closeOptions ();
		} else
		{ // if optionsmenu is off, open options
			openOptions ();
		}
	}
    // set the optionsmenu active, and turn off the mainscreen, and turn the boolean to true
    public void openOptions()
	{ 
		optionsMenu.SetActive (true);
		mainScreen.SetActive (false);
		isOptionsMenu = true;
	}
    // set the main screen active, and turn off the options menu, and turn the boolean to false
	public void closeOptions()
	{ 
		mainScreen.SetActive (true);
		optionsMenu.SetActive (false);
		isOptionsMenu = false;
	}

}

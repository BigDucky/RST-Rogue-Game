using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButton: MonoBehaviour {
    // if you click the button, run the quitgame function
	public void onClick()
	{
			QuitGame ();
	}

    // run an if statement checking if you are inside the unity editor or not
    // if you are inside the unity editor, turn the editor off
    // if you are not, simply quit the application
	public void QuitGame()
	{
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
	}
}
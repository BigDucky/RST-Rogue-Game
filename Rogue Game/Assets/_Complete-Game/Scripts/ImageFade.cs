using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ImageFade : MonoBehaviour {
    // image for the level
    public static Image levelImage;
	// Use this for initialization
	void Start () {
        // run the fade in function with 0.5f as a parameter, and set the level image to the image on the level game object
        levelImage = this.gameObject.GetComponent<Image>();
        FadeIn(0.5f);
	}
	// take the 0.5f as time, and fade in the level image
    public static void FadeIn(float time) {
        levelImage.CrossFadeAlpha(0, time, false);
    }
    // take the exact same time to fade out the image
    public static void FadeOut(float time) {
        levelImage.gameObject.SetActive(true);
        levelImage.CrossFadeAlpha(0f, 0f, true); // needed to 
        levelImage.CrossFadeAlpha(1, time, true);
    }
}

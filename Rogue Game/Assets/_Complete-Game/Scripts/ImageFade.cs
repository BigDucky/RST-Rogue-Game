using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ImageFade : MonoBehaviour {
    public static Image levelImage;
	// Use this for initialization
	void Start () {
        levelImage = this.gameObject.GetComponent<Image>();
        FadeIn();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void FadeIn() {
        levelImage.CrossFadeAlpha(0, 5, false);
    }

    public static void FadeOut() {
        levelImage.gameObject.SetActive(true);
        levelImage.CrossFadeAlpha(255, 2, false);
    }
}

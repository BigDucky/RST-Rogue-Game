using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour {
    
    public static GameObject cam;           // game object camera
    public static GameObject hurtImage;     // game object image to display when you are hurt
    public GameObject image;

    public void Start() {
        // camera variable is the object this script is attached to (the camera)
        cam = this.gameObject;
        // hurt image is the gameobject named HurtImage
        hurtImage = GameObject.Find("HurtImage");
        // disable the hurtimage
        hurtImage.gameObject.SetActive(false);

    }
    // function for the shaking, taking a duration and a strength
    public static IEnumerator Shake( float duration, float strenght) {
        // original position is the camera's position
        Vector3 originalPos = cam.transform.position;
        // time passed since the shake is 0
        float timePassed = 0f;
        // while the timepassed is lower than the duration of the shake
        while (timePassed < duration) {
            // enable the hurt image
            hurtImage.gameObject.SetActive(true);
            // set 2 random numbers, x and y for the camera
            float randomX = Random.Range(originalPos.x -strenght, originalPos.x +strenght);
            float randomY = Random.Range(originalPos.y -strenght, originalPos.y +strenght);
            // move the camera with the random numbers generated above
            cam.transform.position = new Vector3(randomX, randomY, originalPos.z);
            // time passed is the actual time passed in unity
            timePassed += Time.deltaTime;
            yield return null;
        }
        // after the shaking, disable the hurt image
        hurtImage.gameObject.SetActive(false);
        // give the camera its original position again
        cam.transform.position = originalPos;
    }
}
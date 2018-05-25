using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionsScript : MonoBehaviour {
    // variable for the audiomixer
    public AudioMixer audioMixer;
    // volume function, taking the volume as a parameter
    public void VolumeController(float volume)
    {
        // set the audiomixer volume to the volume given by the volume slider
        audioMixer.SetFloat("volume", volume);
    }
}
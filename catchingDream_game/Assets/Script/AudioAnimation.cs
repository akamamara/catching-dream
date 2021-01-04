using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioAnimation : MonoBehaviour
{
     public AudioClip SoundToPlay;
    public AudioSource source;
   
   
    void Awake () {
       
        source = GetComponent<AudioSource>();
    }
   
    void playSound() {
       
        source.PlayOneShot(SoundToPlay);
    }
   
    void Update () {
       
       
    }
}

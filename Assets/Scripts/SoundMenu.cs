using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMenu : MonoBehaviour {
    public AudioSource sound;
    public AudioClip button;

    public void SoundButton() //Llamamos a estafuncion a traves del Event Trigger
    {
        sound.clip = button;
        //se activa y desactiva
        sound.enabled = false;
        sound.enabled = true;
    }
 
}

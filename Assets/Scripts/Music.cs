using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioSource sound;

    void Start()
    {
        sound.Play();
    }

}

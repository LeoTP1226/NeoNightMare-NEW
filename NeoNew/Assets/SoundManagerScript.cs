using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip BatHit, ButtonSelect, CharaDeath, RainSound, DamageSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        BatHit = Resources.Load<AudioClip>("BatHit");
        ButtonSelect = Resources.Load<AudioClip>("ButtonSelect");
        CharaDeath = Resources.Load<AudioClip>("CharaDeath");
        RainSound = Resources.Load<AudioClip>("RainSound");
        DamageSound = Resources.Load<AudioClip>("DamageSound");

        audioSrc = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        
    }
    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "Hit":
                audioSrc.PlayOneShot(BatHit);
                break;
            case "Select":
                audioSrc.PlayOneShot(ButtonSelect);
                break;
            case "CharaDeath":
                audioSrc.PlayOneShot(CharaDeath);
                break;
            case "Rain":
                audioSrc.PlayOneShot(RainSound);
                break;
            case "Dmg":
                audioSrc.PlayOneShot(DamageSound);
                break;
        }
    }
}

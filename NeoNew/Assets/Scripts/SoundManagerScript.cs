using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip SFX_BatHit, SFX_ButtonSelect, SFX_CharacterDeath, SFX_RainSound, SFX_DamageSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        SFX_BatHit = Resources.Load<AudioClip>("SFX_BatHit");
        SFX_ButtonSelect = Resources.Load<AudioClip>("SFX_ButtonSelect");
        SFX_CharacterDeath = Resources.Load<AudioClip>("SFX_CharacterDeath");
        SFX_RainSound = Resources.Load<AudioClip>("SFX_RainSound");
        SFX_DamageSound = Resources.Load<AudioClip>("SFX_DamageSound");

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
                audioSrc.PlayOneShot(SFX_BatHit);
                break;
            case "Select":
                audioSrc.PlayOneShot(SFX_ButtonSelect);
                break;
            case "CharaDeath":
                audioSrc.PlayOneShot(SFX_CharacterDeath);
                break;
            case "Rain":
                audioSrc.PlayOneShot(SFX_RainSound);
                break;
            case "Dmg":
                audioSrc.PlayOneShot(SFX_DamageSound);
                break;
        }
    }
}

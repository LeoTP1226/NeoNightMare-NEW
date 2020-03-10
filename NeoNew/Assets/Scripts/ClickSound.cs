using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ClickSound : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioClip sounds;

    private Button button { get { return GetComponent<Button>(); } }
    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        source.clip = sounds;
        source.playOnAwake = false;

        button.onClick.AddListener(() => PlaySound());

        
    }
    void PlaySound()
    {
        source.PlayOneShot(sounds);
    }

}

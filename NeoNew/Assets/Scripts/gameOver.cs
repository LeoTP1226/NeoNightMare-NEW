﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Healthiness.PlayerIsDead())
        {
            print("You died!");
            Over();
            Healthiness.resetPlayer();
            ScoreScript.scoreValue = 0;
            SoundManagerScript.PlaySound("CharaDeath");
        }
    }

    void Over()
    {
        Invoke("ChangeLevel", 2.5f);
        print("change level");
    }

    void ChangeLevel()
    {
        SceneManager.LoadScene(0);
    }
}

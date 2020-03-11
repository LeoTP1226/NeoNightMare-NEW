using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BatHit : MonoBehaviour
{
    public Slider health;
    public string opponent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != opponent) return;
        Debug.Log("Hit the enemy");
       
        health.value -= 1;
        if(health.value <= 0)
        {
            //write your destroy code here
        }
        

    }
}

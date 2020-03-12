using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BatHit : MonoBehaviour
{

    public string opponent;
    public ParticleSystem deathParticles;
    private bool isDead = false;
    public int health = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != opponent) return;
        Debug.Log("Hit the enemy");


        health -= 1;
        if(health <= 0)
        {
            Death();
            ScoreScript.scoreValue += 1;
        }
        

    }


    void Death()
    {
        Instantiate(deathParticles, transform.position, Quaternion.identity);
        isDead = true;
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BatHit : MonoBehaviour
{
    public int health = 1;
    public string Opposite;
    private bool isDead = false;
    public ParticleSystem deathParticles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != Opposite) return;
        Debug.Log("Hit the enemy");
       
        health -= 1;
        if(health <= 0)
        {
            isDead = true;
            Destroy(gameObject);
            Instantiate(deathParticles, transform.position, Quaternion.identity);
            ScoreScript.scoreValue += 10;
        }
        

    }
}

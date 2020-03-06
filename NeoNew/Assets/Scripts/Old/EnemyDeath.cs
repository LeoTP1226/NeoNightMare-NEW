using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public int Health = 1;
    private bool isDead = false;
    public ParticleSystem deathParticles;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Bat")
        {
            PlayerDamage();
        }

    }

    void PlayerDamage()
    {
        Health -= 1;

        if (Health <= 0)
        {
            Death();
        }
    }

    void Death()
    {
        Instantiate(deathParticles, transform.position, Quaternion.identity);
        isDead = true;
        ScoreScript.scoreValue += 10;
        Destroy(gameObject);
    }

}

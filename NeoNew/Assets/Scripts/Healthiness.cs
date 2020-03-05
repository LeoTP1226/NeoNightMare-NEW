using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthiness : MonoBehaviour
{
    public int health;
    public int numOfHearts;
    public ParticleSystem deathParticles;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    private void Update()
    {
        if (health > numOfHearts)
        {
            health = numOfHearts;

        }
        for (int i = 0; i < hearts.Length; i++)
        {

            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;

            }
        }
    }
    public int CharaHealth = 3;
    public float speed;

    private bool isDead = false;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Enemy")
        {
            EnemyDamage();
        }

    }

    void EnemyDamage()
    {
        CharaHealth -= 1;
        numOfHearts -= 1;

        if (CharaHealth <= 0)
        {
            Death();

        }
    }

    void Death()
    {
        isDead = true;
        Instantiate(deathParticles, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}

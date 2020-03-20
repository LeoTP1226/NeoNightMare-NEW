using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberOfHearts : MonoBehaviour
{
    public int health;
    public int numOfHearts;
    public ParticleSystem deathParticles;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    public GameObject Player;
    public GameObject Heart01;

    [SerializeField] private static bool isDead;

    // Update is called once per frame
    public void Update()
    {
        if (health > numOfHearts)
        {
            health = numOfHearts;

        }
        for (int i = 1; i < hearts.Length; i++)
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

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Enemy")
        {
            EnemyDamage();
            SoundManagerScript.PlaySound("Dmg");
        }

    }

    public void EnemyDamage()
    {
        CharaHealth -= 1;
        numOfHearts -= 1;

        if (CharaHealth < 1)
        {
            Death();
            Heart01.SetActive(false);
        }
    }

   void Death()
    {
        isDead = true;
        Instantiate(deathParticles, transform.position, Quaternion.identity);
        Destroy(Player.gameObject);
    }

    public static bool PlayerIsDead()
    {
        return isDead;
    }

    public static void resetPlayer()
    {
        isDead = false;
    }
}

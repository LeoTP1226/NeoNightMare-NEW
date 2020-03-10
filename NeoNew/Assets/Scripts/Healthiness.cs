using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Healthiness : MonoBehaviour
{
    public int health;
    public int numOfHearts;
    public ParticleSystem deathParticles;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    private float timer = 0;

    //[SerializeField] private GameObject OverMenuUI;
    [SerializeField] private static bool isDead;

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
        }
    }

    void Death()
    {
        isDead = true;
        Instantiate(deathParticles, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
        
    }

    public static bool PlayerIsDead()
    {
        return isDead;
    }

    public static void resetPlayer()
    {
        isDead = false;
    }

    void ChangeLevel()
    {
        SceneManager.LoadScene(0);
    }

    /*
    public void ActivateMenu()
    {
        Time.timeScale = 0;
        OverMenuUI.SetActive(true);
    }

    public void DeactivateMenu()
    {
        Time.timeScale = 1;
        OverMenuUI.SetActive(false);
        OverMenuUI.SetActive(false);
        isDead = false;
    } */
}

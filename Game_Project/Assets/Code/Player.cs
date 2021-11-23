using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    
    public int health;
    public int numOfHearts;

    public Image[] hearts;

    private void Update()
    {
        if(health < numOfHearts)
        {
            numOfHearts = health;
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

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "EnemySnake")
        {
            GetComponent<AudioSource>().Play();
            health -= 1;
            if (health == 0)
            {
                print("GAME OVER!");
                StartCoroutine(loadNextScene());
            }
        }
    }

    private void toNextScene()
    {
        SceneManager.LoadScene("GAMEOVER");
    }

    IEnumerator loadNextScene()
    {
        yield return new WaitForSeconds(0.5f);
        toNextScene();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name == "Level_Exit")
        {
            //GetComponent<AudioSource>().Play();
            SceneManager.LoadScene("MainMenu");
        }

    }
}

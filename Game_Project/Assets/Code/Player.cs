using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int lives = 3;



    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "EnemySnake")
        {
            GetComponent<AudioSource>().Play();
            lives -= 1;
            if (lives == 0)
            {
                print("GAME OVER!");
                SceneManager.LoadScene("GAMEOVER");
            }
        }
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

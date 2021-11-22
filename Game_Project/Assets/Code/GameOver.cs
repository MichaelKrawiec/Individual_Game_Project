using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(loadMainMenu());
    }

    IEnumerator loadMainMenu()
    {

        yield return new WaitForSeconds(4.0f);
        MainMenu();


    }
    private void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

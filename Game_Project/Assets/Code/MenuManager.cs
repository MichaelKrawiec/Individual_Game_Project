using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MenuManager : MonoBehaviour
{
    public void LoadScene(string name)
    {
        Application.LoadLevel(name);
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}

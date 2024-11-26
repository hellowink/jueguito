using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void gameStart(string levelOne)
    {
        SceneManager.LoadScene("levelOne");
        Debug.Log("Cambio de escena");
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Se sale");
    }

    public void Restart()
    {
        SceneManager.LoadScene("levelOne");
        Debug.Log("Cambio de escena");
    }
}
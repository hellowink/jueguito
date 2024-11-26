using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    public GameObject pause; 
    public MonoBehaviour camera2;

    private bool isPaused = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        pause.SetActive(true); 
        Time.timeScale = 0f; 
        camera2.enabled = false; 
        isPaused = true;
    }

    public void ResumeGame()
    {
        pause.SetActive(false); 
        Time.timeScale = 1f;
        camera2.enabled = true; 
        isPaused = false;
    }

    public void Restart()
    {
        SceneManager.LoadScene("levelOne");
        Time.timeScale = 1f;
    }

    public void Menu()
    {
        SceneManager.LoadScene("MenuInicial");
        Time.timeScale = 1f;
    }
}

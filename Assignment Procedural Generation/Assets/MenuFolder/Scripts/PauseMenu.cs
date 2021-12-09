using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    //boolean for if game is paused
    //
    public static bool GameisPaused = false;
    //Canvas UI
    //
    public GameObject PauseMenuUI;

    //Method if escape key is pressed then call methods for Pausemenu
    //
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameisPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        //play time
        //
        Time.timeScale = 1f;
        GameisPaused = false;
    }
    void Pause()
    {
        PauseMenuUI.SetActive(true);
        
        //Stop time
        //
        Time.timeScale = 0f;
        GameisPaused = true;
    }

    //method for switching to main menu scene
    //
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Start Menu1");
    }
}

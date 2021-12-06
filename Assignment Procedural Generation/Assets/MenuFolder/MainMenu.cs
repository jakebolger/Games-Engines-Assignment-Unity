using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    //function for Explore button game that accesses scenmanager and sets build index + 1.
    //
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //function for mini game button game that accesses scenmanager and sets build index + 2.
    //
    public void PlayGameMini()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    //function for quit buttoin than displays Quit! in console.
    //
    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}

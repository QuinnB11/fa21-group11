using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayNewGame()
    {
        SceneManager.LoadScene("SampleScene");
        Debug.Log("Start new game");
    }

    public void PlaySavedGame()
    {
        //SceneManager.LoadScene("");
        Debug.Log("Load savegame");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit game");
    }

    public void PlayTestLevel()
    {
        SceneManager.LoadScene("SampleScene");
        Debug.Log("Load test level");
    }
}

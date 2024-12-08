using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void onPlayButton()
    {
        SceneManager.LoadScene("Level");
    }

    public void onOptions()
    {
        SceneManager.LoadScene("Options");
    }

    public void onQuit()
    {
        Application.Quit();
    }
}

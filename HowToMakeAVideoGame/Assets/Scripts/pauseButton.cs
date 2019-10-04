using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseButton : MonoBehaviour
{
   
    public GameObject pauseUI;
 


    public void Toggle()
    {

        pauseUI.SetActive(!pauseUI.activeSelf);
        if (pauseUI.activeSelf)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
    public void close()
    {
        Application.Quit();
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool gameIsPaused = false;

    public GameObject pauseUI, pauseBtn;

    public void Resume()
    {
        pauseUI.SetActive(false);
        pauseBtn.SetActive(true);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    public void Pause()
    {
        pauseUI.SetActive(true);
        pauseBtn.SetActive(false);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        if (Confirm.resetAll)
        {
            SceneManager.LoadScene("MainMenu");
        }
        else
        {
            SceneManager.LoadScene("Menuw_HighScore");
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}

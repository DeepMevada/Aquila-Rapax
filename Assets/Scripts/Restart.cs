using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Restart : MonoBehaviour
{
    public static bool gameover = false;
    public TextMeshProUGUI highscr;
    public GameObject pause;
    void Update()
    {
        highscr.text = PlayerPrefs.GetInt("HighScore", 0).ToString();

        if (Input.GetKeyDown(KeyCode.R))
        {
            gameover = true;
            pause.SetActive(true);
            SceneManager.LoadScene("Start");

        }

        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Confirm.resetAll)
            {
                gameover = false;
                SceneManager.LoadScene("MainMenu");
            }
            else
            {
                SceneManager.LoadScene("Menuw_HighScore");
            }
        }
    }

    public void restartGame()
    {
        gameover = true;
        pause.SetActive(true);
        SceneManager.LoadScene("Start");
    }

    public void mainMenu()
    {
        if (Confirm.resetAll)
        {
            gameover = false;
            SceneManager.LoadScene("MainMenu");
        }
        else
        {
            SceneManager.LoadScene("Menuw_HighScore");
        }
    }

    public void quitGame()
    {
        Application.Quit();
    }
}

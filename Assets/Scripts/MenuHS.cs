using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class MenuHS : MonoBehaviour
{
    public Animator helpanim, audioAnim, transAnim, creditAnim;
    public TextMeshProUGUI highscr;
    public float waitTime;

    void Start()
    {
        highscr.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
    public void PlayGame()
    {
        if (PlayerPrefs.GetInt("tutdone") != 1)
        {
            StartCoroutine(ChangeScene("Tutorial"));
        }

        else
        {
            StartCoroutine(ChangeScene("Start"));
        }

    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Help()
    {
        helpanim.SetTrigger("slidetrg");
    }

    public void BackToMainMenu()
    {
        helpanim.SetTrigger("exittrg");
    }

    public void Credits()
    {
        creditAnim.SetTrigger("enter");
    }

    public void CreditsToMenu()
    {
        creditAnim.SetTrigger("exit");
    }

    IEnumerator ChangeScene(string sceneName)
    {
        audioAnim.SetTrigger("fadeOut");
        transAnim.SetTrigger("end");
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(sceneName);
    }
}

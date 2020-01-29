using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Animator helpanim, musicAnim, transAnim, creditAnim;
    public AudioSource audioMain;
    public float waitTime;
    public void PlayGame()
    {
        Confirm.resetAll = false;
        /*PlayerPrefs.DeleteAll();*/

        if (PlayerPrefs.GetInt("tutdone") != 1)
        {
            StartCoroutine(ChangeScene("Tutorial"));
            //SceneManager.LoadScene("Tutorial");
           
        }

        else
        {
            StartCoroutine(ChangeScene("Start"));
            // SceneManager.LoadScene("Start");
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
        musicAnim.SetTrigger("fadeOut");
        transAnim.SetTrigger("end");
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(sceneName);
    }


}

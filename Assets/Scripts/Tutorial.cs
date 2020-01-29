using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    public Animator transAnim, musicAnim;
    public float waitTime;
    public Animator mainAnim;

    void Start()
    {
        mainAnim = GetComponent<Animator>();
    }
    public void Play()
    {
        PlayerPrefs.SetInt("tutdone", 1);
        PlayerPrefs.SetInt("HighScore", 0);
        StartCoroutine(NextScene());
    }

    // public void FadeOut()
    // {
    //     transAnim.SetTrigger("end");
    // }

    // public void OnFadeComplete()
    // {
    //     SceneManager.LoadScene("Start");
    // }

    IEnumerator NextScene()
    {
        musicAnim.SetTrigger("fadeOut");
        transAnim.SetTrigger("end");
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene("Start");
    }

    public void welcomeExit()
    {
        mainAnim.SetTrigger("wel_exit");
    }
}

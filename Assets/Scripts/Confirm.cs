using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Confirm : MonoBehaviour
{
    public static bool resetAll = false;

    public void YesBtn()
    {
        PlayerPrefs.SetInt("HighScore", 0);
        resetAll = true;
        SceneManager.LoadScene("MainMenu");
    }

    public void NoBtn()
    {
        gameObject.SetActive(false);
    }
}

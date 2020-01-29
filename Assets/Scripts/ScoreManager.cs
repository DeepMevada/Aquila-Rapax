using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreDis;
    public Player p;
    private int score = 0;
    void Start()
    {
        // scoreDis = GetComponentInChildren<TextMeshProUGUI>();
    }

    void Update()
    {
        if (p.health <= 0)
        {
            Destroy(gameObject);
        }
        scoreDis.text = score.ToString();
        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
    void OnTriggerEnter2D(Collider2D obs)
    {
        if (obs.CompareTag("Obstacle"))
        {
            score++;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    private Shake shake;
    private Vector2 targetPos;
    public float yIncr = 5;
    public float speed = 5;
    public float maxHeight;
    public float minHeight;
    private AudioSource wings;

    public int health = 3;
    public TextMeshProUGUI healthDis;
    public GameObject effect;
    public GameObject gameOver, pause, controls;
    // Update is called once per frame
    void Start()
    {
        Time.timeScale = 1f;
        wings = GetComponent<AudioSource>();
        healthDis = GetComponentInChildren<TextMeshProUGUI>();
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
    }
    void Update()
    {
        healthDis.text = health.ToString();

        if (health <= 0)
        {
            gameOver.SetActive(true);
            pause.SetActive(false);
            controls.SetActive(false);
            Destroy(gameObject);
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        // if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && transform.position.y < maxHeight)
        // {
        //     Instantiate(effect, transform.position, Quaternion.identity);
        //     shake.PlayerShakeUp();
        //     targetPos = new Vector2(transform.position.x, transform.position.y + yIncr);
        // }
        // else if ((Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) && transform.position.y > minHeight)
        // {
        //     Instantiate(effect, transform.position, Quaternion.identity);
        //     shake.PlayerShakeDown();
        //     targetPos = new Vector2(transform.position.x, transform.position.y - yIncr);
        // }
    }

    void PlayWing()
    {
        wings.Play();
    }

    public void goUp()
    {
        if (transform.position.y < maxHeight)
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            shake.PlayerShakeUp();
            targetPos = new Vector2(transform.position.x, transform.position.y + yIncr);
        }
    }

    public void goDown()
    {
        if (transform.position.y > minHeight)
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            shake.PlayerShakeDown();
            targetPos = new Vector2(transform.position.x, transform.position.y - yIncr);
        }
    }
}

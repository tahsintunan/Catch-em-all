using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Basic : MonoBehaviour
{
    public int health = 5;
    public int score = 0;

    public TextMeshProUGUI healthDisplay;
    public TextMeshProUGUI scoreDisplay;
    public TextMeshProUGUI scoreDisplay2;

    public GameObject gameOver;


    private void Update()
    {
        healthDisplay.text = health.ToString();
        scoreDisplay.text = score.ToString();
        scoreDisplay2.text = "Your Score is " + score.ToString();

        if (health <= 0)
        {
            if (PlayerPrefs.GetFloat("Highscore") < score)
            {
                PlayerPrefs.SetFloat("Highscore", score);
            }

            gameOver.SetActive(true);
            Destroy(gameObject);
        }
    }
}


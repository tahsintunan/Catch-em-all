using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameSession : MonoBehaviour
{
    public int score = 0;
    public int health = 5;
    public int maxHealth = 5;
    
    public TextMeshProUGUI healthDisplay;
    public TextMeshProUGUI scoreDisplay;
    public TextMeshProUGUI scoreText;

    public GameObject gameOver;


    private void Update()
    {
        updateUI();
        if (health <= 0)
        {
            if (PlayerPrefs.GetFloat("Highscore") < score)
                PlayerPrefs.SetFloat("Highscore", score);
            gameOver.SetActive(true);
            Destroy(gameObject);
        }
    }

    private void updateUI()
    {
        healthDisplay.text = health.ToString();
        scoreDisplay.text = score.ToString();
        scoreText.text = "Your Score is " + score.ToString();
    }
}


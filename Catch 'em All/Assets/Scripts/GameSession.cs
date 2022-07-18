using UnityEngine;
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
        UpdateUI();
        if (health > 0) return;
        if (PlayerPrefs.GetFloat("Highscore") < score)
            PlayerPrefs.SetFloat("Highscore", score);
        gameOver.SetActive(true);
        Time.timeScale = 0.1f;
        Destroy(gameObject);
    }

    private void UpdateUI()
    {
        healthDisplay.text = health.ToString();
        scoreDisplay.text = score.ToString();
        scoreText.text = "Your Score is " + score;
    }
}


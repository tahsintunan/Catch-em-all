using UnityEngine;
using TMPro;

public class HighscoreGrabber : MonoBehaviour
{
    public TextMeshProUGUI highScore;

    private void Start()
    {
        highScore.text = ((int)PlayerPrefs.GetFloat("Highscore")).ToString();
    }
}

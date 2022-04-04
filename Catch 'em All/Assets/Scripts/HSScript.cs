using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HSScript : MonoBehaviour
{
    public TextMeshProUGUI HighScore;

    private void Start()
    {
        HighScore.text = ((int)PlayerPrefs.GetFloat("Highscore")).ToString();
    }
}

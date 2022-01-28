using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class timeGet : MonoBehaviour
{
    public Text timeText;
    public float time;

    public Text ScoreText;
    public int Score;

    void Start()
    {
        time = PlayerPrefs.GetFloat("time");
        Score = PlayerPrefs.GetInt("Score");
    }

    // Update is called once per frame
    void Update()
    {
        timeText.text = $"{time:N2}";
        ScoreText.text = Score.ToString();
    }
}

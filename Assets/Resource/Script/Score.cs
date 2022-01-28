using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public int score;
    public int level;
    public Text scoreText;

    public Text SpeedText;
    public int speed;

    public float time;
    public Text timeText;

    public Text DamageText;
    public int Damage;

    void Start()
    {
        time = PlayerPrefs.GetFloat("time");
        score = PlayerPrefs.GetInt("Score");
        speed = PlayerPrefs.GetInt("Speed");
        level = PlayerPrefs.GetInt("level");
        Damage = PlayerPrefs.GetInt("Damage") +1;
    }

    // Update is called once per frame
    void Update()
    {
        
        scoreText.text = (score).ToString();
        SetLevel();

        SpeedText.text = ((int)speed+1).ToString();
        time += Time.deltaTime;
        timeText.text = $"{time:N2}";
        PlayerPrefs.SetFloat("time",time);

        DamageText.text = (Damage).ToString();
    }
    public void coin()
    {
        score += 10;
        PlayerPrefs.SetInt("Score", score);
    }
    public void SceneChange()
    {
        SceneManager.LoadScene(2);
    }
    public void SetLevel()
    {
        if (score >= level)
        {
            level += 100;
            PlayerPrefs.SetInt("level", level);           
            Invoke("SceneChange",0.5f);
            
        }
    }
    
}

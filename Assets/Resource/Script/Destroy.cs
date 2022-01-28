using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Destroy : MonoBehaviour
{
    public Slider healthbar;
    public Text healthText;
    public int health;

    public AudioClip audio1;
    AudioSource audioSource;

    void Awake()
    {
        this.audioSource = GetComponent<AudioSource>();
    }

    void Start()
    {
        healthbar.value = PlayerPrefs.GetInt("Health");
        //health = PlayerPrefs.GetInt("Health");
        
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = healthbar.value.ToString();
        HPzero();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ENEMY")
        {
            HPdown();
            
            Debug.Log("True");
            other.gameObject.SetActive(false);
        }
    }
    public void HPdown()
    {
        PlaySound("HP");
        healthbar.value -= 10;
        health= (int)healthbar.value;
        PlayerPrefs.SetInt("Health", health);
    }
    public void HPzero()
    {
        if(healthbar.value <= 0)
        {
            SceneManager.LoadScene(3);
        }
    }
    void PlaySound(string action)
    {
        switch (action)
        {
            case "HP":
                audioSource.clip = audio1;
                break;
        }
        audioSource.Play();
    }
}

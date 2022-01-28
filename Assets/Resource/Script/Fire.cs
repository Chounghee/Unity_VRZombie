using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject razer;
    public GameObject fire;
    public RaycastHit hit;

    public int count = 0;
    public int Damage=0;

    public AudioClip audio1;
    AudioSource audioSource;

    void Awake()
    {
        this.audioSource = GetComponent<AudioSource>();
    }
    void Start()
    {
        Damage = PlayerPrefs.GetInt("Damage");

       
    }
    
    public void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //RaycastHit hit;
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 1000;
       
        if(Input.GetMouseButtonDown(0))
        {
            PlaySound("gun");
            if (Physics.Raycast(ray, out hit, 100f))
            {
                razer.SetActive(true);
                fire.SetActive(true);
                if (hit.collider.tag == "ENEMY")
                {                  
                    count++;
                    if(count > Damage)
                    {
                        
                        hit.transform.gameObject.SetActive(false);
                        GameObject.Find("Head").GetComponent<Score>().coin();
                        count = 0;
                    }
                    
                }                          
            }
            
        }
        if (Input.GetMouseButtonUp(0))
        {
            razer.SetActive(false);
            fire.SetActive(false);
        }
        
    }    
    void PlaySound(string action)
    {
        switch (action)
        {
            case "gun":
                audioSource.clip = audio1;
                break;
        }
        audioSource.Play();
    }





}

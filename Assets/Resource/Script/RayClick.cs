using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RayClick : MonoBehaviour
{
    private float GaugeTimer = 0.0f;
    public Image cursorGaugeImage;
    public GameObject mainCam;

    public int Damage = 1;
    public int speed = 1;
    public int health = 100;


    void Start()
    {        
        Damage = PlayerPrefs.GetInt("Damage");
        speed = PlayerPrefs.GetInt("Speed");
        health = PlayerPrefs.GetInt("Health");
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Vector3 forward = mainCam.transform.TransformDirection(Vector3.forward) * 1000;
        Debug.DrawRay(this.transform.position, forward, Color.green);
        cursorGaugeImage.fillAmount = GaugeTimer;
        
        if (Physics.Raycast(this.transform.position, forward, out hit))
        {          
            GaugeTimer += Time.deltaTime;
            Debug.Log("hit");
            if (GaugeTimer >= 2.0f)
            {
                if(hit.collider.tag == "Button1")
                {                   
                    Damage++;
                    PlayerPrefs.SetInt("Damage", Damage);
                    hit.transform.GetComponent<Button>().onClick.Invoke();

                }
                else if (hit.collider.tag == "Button2")
                {
                    health -= 10;
                    PlayerPrefs.SetInt("Health", health);
                    hit.transform.GetComponent<Button>().onClick.Invoke();
                }
                else if (hit.collider.tag == "Button3")
                {
                    speed++;
                    PlayerPrefs.SetInt("Speed", speed);
                                      
                    hit.transform.GetComponent<Button>().onClick.Invoke();
                }
                else if(hit.collider.tag == "Button")
                {
                    PlayerPrefs.DeleteAll();
                    PlayerPrefs.SetInt("level", 100);
                    PlayerPrefs.SetInt("Health", 100);
                    hit.transform.GetComponent<Button>().onClick.Invoke();
                }
                //PlayerPrefs.Save();
                //GaugeTimer = 0.0f;
            }
            
        }
        else
        {
            GaugeTimer = 0.0f;
        }
    }
}

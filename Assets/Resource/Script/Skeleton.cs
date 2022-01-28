using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : MonoBehaviour
{
    public GameObject Idle;
    public GameObject Death;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Fire")
        {
            Idle.gameObject.SetActive(false);
            Death.gameObject.SetActive(true);
        }
    }
}

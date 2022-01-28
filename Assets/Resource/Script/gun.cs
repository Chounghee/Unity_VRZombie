using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePosition;

    public float timeBetFire = 0.6f;
    private float lastFireTime = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(Time.time >= lastFireTime + timeBetFire)
            {
                Fire();
            }
        }
    }
    void Fire()
    {
        lastFireTime = Time.time;
        Instantiate(bulletPrefab, firePosition.position, firePosition.rotation);
    }
}

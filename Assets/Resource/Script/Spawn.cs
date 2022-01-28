using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    private float timer=0.0f;
    float wait=2.0f;

    public int enemySpeed=1;
    void start()
    {
        InvokeRepeating("SpawnEnemy", 3, 1);
        PlayerPrefs.GetInt("Speed", 0);
    }
    void Start()
    {
        //for (int i = 0; i < 5; i++)
            //Instantiate(enemy1, GetRandomPosition(), Quaternion.identity);
    }
    public Vector3 GetRandomPosition()
    {
        float radius = 10f;
        Vector3 playerPosition = transform.position;

        float a = playerPosition.x;
        float b = playerPosition.z;

        float x = Random.Range(-radius + a, radius + a);
        float z_b = Mathf.Sqrt(Mathf.Pow(radius, 2) - Mathf.Pow(x - a, 2));
        z_b *= Random.Range(0, 2) == 0 ? -1 : 1;
        float z = z_b + b;

        Vector3 randomPosition = new Vector3(x, 0, z);

        return randomPosition;
    }
    public void SpawnEnemy()
    {
        Instantiate(enemy1, GetRandomPosition(), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {       
        if (PlayerPrefs.GetInt("Speed") == 0)
        {
            Spawn1();
        }
        if (PlayerPrefs.GetInt("Speed") == 1)
        {
            Spawn2();
        }
        if (PlayerPrefs.GetInt("Speed") >= 2)
        {
            Spawn3();
        }
    }
    public void Spawn1()
    {
        timer += Time.deltaTime;
        Debug.Log(timer);
        if (timer > wait)
        {
            Instantiate(enemy1, GetRandomPosition(), Quaternion.identity);
            wait += 1.0f;
        }
    }
    public void Spawn2()
    {
        timer += Time.deltaTime;
        Debug.Log(timer);
        if (timer > wait)
        {
            Instantiate(enemy2, GetRandomPosition(), Quaternion.identity);
            wait += 1.0f;
        }
    }
    public void Spawn3()
    {
        timer += Time.deltaTime;
        Debug.Log(timer);
        if (timer > wait)
        {
            Instantiate(enemy3, GetRandomPosition(), Quaternion.identity);
            wait += 1.0f;
        }
    }
}

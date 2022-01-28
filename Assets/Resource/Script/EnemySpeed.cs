using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemySpeed : MonoBehaviour
{
    public GameObject enemy;
    NavMeshAgent agent;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EnemySpeedUp()
    {
        agent = GameObject.Find("Capsule").GetComponent<NavMeshAgent>();
        agent.speed++;
    }
}

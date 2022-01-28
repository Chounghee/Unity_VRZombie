using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private Transform monstertr;
    private Transform playertr;
    private NavMeshAgent nvAgent;

    public GameObject ps;
    

    public void Awake()
    {
        
    }
    void Start()
    {
        monstertr = gameObject.GetComponent<Transform>();
        playertr = GameObject.FindWithTag("Player").GetComponent<Transform>();

        nvAgent = gameObject.GetComponent<NavMeshAgent>();
        nvAgent.destination = playertr.position;

        
    }

    // Update is called once per frame
    void Update()
    {      
        
    }
    public void Particle()
    {
        Instantiate(ps, transform.position, transform.rotation);
    }
}

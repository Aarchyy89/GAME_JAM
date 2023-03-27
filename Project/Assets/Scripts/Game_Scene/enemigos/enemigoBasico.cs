using System.Collections;
using System;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class enemigoBasico : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Transform player;
    public static enemigoBasico instance;
    public GameObject screamer;
    private void Awake()
    {
        instance = this;
        
    }

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;

        
    }

    void Update()
    {
        
        navMeshAgent.SetDestination(player.position);
    }

    public void StopEnemy()
    {
        navMeshAgent.isStopped = true;
    }

    public void GoToTarget()
    {
        navMeshAgent.isStopped = false;
        navMeshAgent.SetDestination(player.position);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            screamer.SetActive(true);
            Level_Manager.instance.Die();
        }
    }

    
    
}

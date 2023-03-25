using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class enemigoBasico : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Transform player;



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

    
}

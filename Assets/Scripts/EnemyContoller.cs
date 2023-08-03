using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyContoller : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    [SerializeField] Transform targetPlayer;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        if(Vector3.Distance(targetPlayer.position, transform.position)< 10)
        {
            agent.destination = targetPlayer.position;
        }
        
    }
}

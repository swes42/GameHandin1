    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CatchPlayer : MonoBehaviour
{
    NavMeshAgent navMeshAgent = null;
    Animator animator;

    public Transform cheese;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

        //cheese = GameObject.FindGameObjectWithTag("Player"); 
    }
        
    void Update()   
    {   

        //targetPos = cheese.transform.position;

        navMeshAgent.SetDestination(cheese.position);
        animator.SetFloat("Speed", 0.7f);

    }
}

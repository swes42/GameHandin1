using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveBetweenWaypoints : MonoBehaviour
{
    public List<GameObject> Waypoints; // this list is populated in the inspector
    private NavMeshAgent navMeshAgent;

    private Animator animator;

    private int currentWaypoint;

    void Start() 
    {
        currentWaypoint = 0;
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }
    
    void Update()
    {
        // Measure distance from current waypoint
        if (Vector3.Distance(transform.position, Waypoints[currentWaypoint].transform.position) < 1.0f)
        {
            // We are within range of current waypoint, so we set the next waypoint as the active one
            currentWaypoint++;
            if (currentWaypoint >= Waypoints.Count)
            {
                currentWaypoint = 0; // reset to first waypoint, if there are no more waypoints in list.
            }
            Debug.Log($"Now moving towards waypoint {currentWaypoint}");
        } 
        else
        {
            // Move to waypoint
            navMeshAgent.SetDestination(Waypoints[currentWaypoint].transform.position);
        }

        if (navMeshAgent.isStopped == true) 
        {
            animator.SetFloat("Speed", 0.0f);
        }
        else
        {
            animator.SetFloat("Speed", 0.7f);
        }
    }
}

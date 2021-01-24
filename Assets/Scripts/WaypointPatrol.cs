using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

public class WaypointPatrol : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Transform[] waypoints;

    int m_CurrentWaypointIndex;

    [SerializeField] private string playerTag = "Player";
 
    [SerializeField] private GameObject player;
    [SerializeField] private float distanceForChase = 10f;

    [SerializeField] private LayerMask layer;
    public float DistanceForChaseSQRT => distanceForChase * distanceForChase;

    private bool IsInChase = false;

    private RayCastInConus conusCollider;

    void Start ()
    {
        conusCollider = GetComponentInChildren<RayCastInConus>();
        navMeshAgent.SetDestination (waypoints[0].position);
    }

    void Update ()
    {
        if (IsPlayerTooClose() && !IsObstacleBeetweenBotAndPlayer())
        {
            IsInChase = true;         
        }
        else
        {
            IsInChase = false;
        }
    }

    private void LateUpdate()
    {
        if (IsInChase)
        {
            navMeshAgent.SetDestination(player.transform.position);
        }
        else
        {
            //var isCurrentDestinationInWaypoints =
            //    (from t in waypoints
            //     where t.position == navMeshAgent.destination
            //     select t.position).Count() == 1;

            //if (!isCurrentDestinationInWaypoints)
            //{
            //    navMeshAgent.SetDestination(waypoints[m_CurrentWaypointIndex].position);
            //}
            //else
            if (navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance)
            {
                m_CurrentWaypointIndex = (m_CurrentWaypointIndex + 1) % waypoints.Length;
                navMeshAgent.SetDestination(waypoints[m_CurrentWaypointIndex].position);
            }
        }
    }

    private bool IsPlayerTooClose()
    {
        var distanceFromBotToPlayerSQRT = (player.transform.position - transform.position).sqrMagnitude;

        if (distanceFromBotToPlayerSQRT > DistanceForChaseSQRT) return false;

        return true;
    }

    private bool IsObstacleBeetweenBotAndPlayer()
    {
        var hitDirection = (player.transform.position - transform.position).normalized;

        var distanceOfRayCast = 0f;

        RaycastHit hit;
        
        if (Physics.Raycast(transform.position, hitDirection, out hit, layer))
        {
            distanceOfRayCast = hit.distance;
        }

        Debug.DrawRay(transform.position, hitDirection * distanceOfRayCast, Color.red);

        if (hit.transform.CompareTag(playerTag))
        {
            return false;
        }

        return true;
    }
}

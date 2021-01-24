using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastInConus : MonoBehaviour
{
    [SerializeField] private string playerTag = "Player";

    [SerializeField] private GameObject player;

    [SerializeField] private LayerMask layer;


    private void OnTriggerStay(Collider other)
    {
        if (!other.transform.CompareTag(playerTag))
        {
            return;
        }
        var hitDirection = (player.transform.position - transform.position).normalized;

        RaycastHit hit;

        if (Physics.Raycast(transform.position, hitDirection, out hit, layer))
        {

        }

        var hitDirectionv1 = (player.transform.position - transform.position);

        Debug.DrawRay(transform.position,hitDirectionv1);

    }
}

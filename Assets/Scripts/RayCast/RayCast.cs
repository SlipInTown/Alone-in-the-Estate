using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    [SerializeField] private float maxDistanceOfRayCast = 80f;

    private RaycastHit hitRayCast;

    public RaycastHit Hit
    {
        get
        {
            return hitRayCast;
        }
        private set
        {
            hitRayCast = value;
        }
    }

    public Transform pointer;
    
    [SerializeField] private LayerMask layerMask;
    
    void Update()
    {

        if (Physics.Raycast(transform.position, transform.forward, out hitRayCast, maxDistanceOfRayCast, layerMask)) 
        {
            pointer.position = hitRayCast.point;
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    [SerializeField] private float maxDistanceOfRayCast = 80f;
    [SerializeField] public static RaycastHit hitRayCast;
    public Transform pointer;
    [SerializeField] private LayerMask layerMask;
    //[SerializeField] private float realDistance;
    // Update is called once per frame
    void Update()
    {
        //ray = new Ray();
        //Debug.DrawRay(ray.origin,ray.direction*5,Color.red);
        if (Physics.Raycast(transform.position, transform.forward, out hitRayCast, maxDistanceOfRayCast, layerMask)) 
        {
            pointer.position = hitRayCast.point;
            //realDistance = hitRayCast.distance;
        }

    }
}

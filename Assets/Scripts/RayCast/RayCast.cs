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
    private LineRenderer line;

    private void Start()
    {
        //line = GetComponent<LineRenderer>();
       // line.enabled = true;
    }
    void Update()
    {
        //line.SetPosition(0, transform.position);
        if (Physics.Raycast(transform.position, transform.forward, out hitRayCast, maxDistanceOfRayCast, layerMask))
        {
            pointer.position = hitRayCast.point;
            //line.SetPosition(1, hitRayCast.point);
        }
        //Debug.DrawRay(transform.position, transform.forward);
    }
}

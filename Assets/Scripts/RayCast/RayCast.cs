using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    public Transform pointer;
    [SerializeField] private LayerMask layerMask;
    // Update is called once per frame
    void LateUpdate()
    {
        ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(ray.origin,ray.direction*5,Color.red);
        if (Physics.Raycast(ray, out hit, layerMask)) 
        {
            pointer.position = hit.point;
            Selectable select = hit.collider.gameObject.GetComponent<Selectable>();
            if (select) { select.Select(); }
        }

    }
}

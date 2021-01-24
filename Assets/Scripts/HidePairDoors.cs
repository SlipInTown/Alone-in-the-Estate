using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class HidePairDoors : MonoBehaviour
{
    [SerializeField] private MeshRenderer anotherDoor;
    private MeshRenderer meshRenderer;

    void Start()
    { 
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            meshRenderer.enabled = false;
            anotherDoor.enabled = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            meshRenderer.enabled = true;
            anotherDoor.enabled = true;
        }
    }
}

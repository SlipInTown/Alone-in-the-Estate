using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDoors : MonoBehaviour
{
    private MeshCollider meshCollider;
    private MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        meshCollider = GetComponent<MeshCollider>();
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            meshRenderer.enabled = false;
            meshCollider.enabled = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            meshRenderer.enabled = true;
            meshCollider.enabled = true;
        }
    }
}

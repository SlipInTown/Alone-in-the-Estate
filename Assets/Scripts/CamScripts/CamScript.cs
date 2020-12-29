using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour
{
    [SerializeField] private Camera cameraObj;
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Camera.main.transform.position = cameraObj.transform.position;
            Camera.main.transform.rotation = cameraObj.transform.rotation;
        }
    }
    
}

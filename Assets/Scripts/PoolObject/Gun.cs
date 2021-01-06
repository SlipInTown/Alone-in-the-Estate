using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    ObjectPooler objectPooler;

    private void Start()
    {
        objectPooler = ObjectPooler.Instance;
    }
    public void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0)) 
        { 
            objectPooler.SpawnFromPool("Bullet", transform.position, Quaternion.identity);
        }
    }
}

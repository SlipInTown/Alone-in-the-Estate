using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float initialForce;

     
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity, transform);

            var newBallBody = bulletPrefab.GetComponent<Rigidbody>();
            
            newBallBody.AddForce(Vector3.forward * initialForce);
        }
    }
}

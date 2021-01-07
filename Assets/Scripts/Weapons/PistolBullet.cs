using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PistolBullet : MonoBehaviour,IPooledObject
{
    ObjectPooler objectPooler;
    [SerializeField] private float force = 50f;
    private void Start()
    {
        objectPooler = ObjectPooler.Instance;
    }

    public void OnObjectSpawn()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * force;
        //Invoke(nameof(ReturnToPool), 1);
    }

    private void OnCollisionEnter(Collision collision)
    {
        objectPooler.BackInPool(gameObject, gameObject.tag);
    }

}

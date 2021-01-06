using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour,IPooledObject
{
    ObjectPooler objectPooler;
    [SerializeField] private float force = 1000f;

    public void OnObjectSpawn()
    {
        objectPooler = ObjectPooler.Instance;
        GetComponent<Rigidbody>().AddForce(0, 0, force);
        Invoke(nameof(ReturnToPool), 3);
    }

    public void ReturnToPool()
    {
        objectPooler.BackInPool(gameObject, gameObject.tag);
    }
}

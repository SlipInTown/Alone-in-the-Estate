using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PistolBullet : MonoBehaviour,IPooledObject
{
    ObjectPooler objectPooler;
    [SerializeField] private float force = 1000f;
    private Vector3 relative;
    private void Start()
    {
        objectPooler = ObjectPooler.Instance;
    }

    public void OnObjectSpawn()
    {
        //relative.Set(0f, 0f, transform.localPosition.z);
        //transform.LookAt(moveDirection + transform.position);
        GetComponent<Rigidbody>().AddForce(transform.forward);
        Invoke(nameof(ReturnToPool), 1);
    }

    public void ReturnToPool()
    {
        objectPooler.BackInPool(gameObject, gameObject.tag);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineBomb : MonoBehaviour
{
    [SerializeField] private string detectTag;
    [SerializeField] private float bombForce;
    [SerializeField] private float bombDelayDestroy;
    [SerializeField] private float bombRadius;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag(detectTag)) return;

        var otherBody = other.gameObject.GetComponent<Rigidbody>();

        if (otherBody)
        {
            otherBody.AddExplosionForce(bombForce, transform.position, bombRadius);
        }
        Destroy(gameObject,bombDelayDestroy);
    }
}

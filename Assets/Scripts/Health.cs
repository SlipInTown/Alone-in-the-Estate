using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private GameObject owner;
    [SerializeField] private int hpCount = 3;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        hpCount--;
        if (hpCount == 0) Destroy(owner);
    }
}

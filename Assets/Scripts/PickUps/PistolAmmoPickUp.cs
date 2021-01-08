using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolAmmoPickUp : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerInvent.pistolAmmoCount += 5;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolAmmoPickUp : MonoBehaviour
{
    [SerializeField] private string playerTag;
    [SerializeField] private int ammoAddition = 5;
    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag(playerTag)) return;
        PlayerInvent.pistolAmmoCount += ammoAddition;
        Debug.Log($"У вас стало {PlayerInvent.pistolAmmoCount} патронов");
        Destroy(gameObject);
    }
}

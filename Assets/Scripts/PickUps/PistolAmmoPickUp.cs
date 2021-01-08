using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolAmmoPickUp : MonoBehaviour
{
    [SerializeField] private string playerTag;
    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag(playerTag)) return;
        PlayerInvent.pistolAmmoCount += 5;
        Debug.Log($"У вас стало {PlayerInvent.pistolAmmoCount} патронов");
        Destroy(gameObject);
    }
}

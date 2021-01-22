using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickUp : MonoBehaviour
{
    [SerializeField] private string playerTag = "Player";
    [SerializeField] private int ammoAddition = 5;
    [SerializeField] private string ammoPickUpTag;

    private PlayerInvent inventory;

    private void Start()
    {
        inventory = FindObjectOfType<PlayerInvent>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag(playerTag)) return;

        if (ammoPickUpTag == "PistolBullet")
        {
            PistolAmmo tempAmmo = (PistolAmmo)inventory.itemPlayerList[ammoPickUpTag];
            tempAmmo.AmmoCount += ammoAddition;
            Debug.Log($"У вас стало {tempAmmo.AmmoCount} патронов типа {ammoPickUpTag}");
        }
        
        //inventory.playerInventory.Find()
        //PlayerInvent.pistolAmmoCount += ammoAddition;
        
        Destroy(gameObject);
    }
}

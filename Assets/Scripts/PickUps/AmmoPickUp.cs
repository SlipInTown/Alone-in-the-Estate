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
            AddAmmo(tempAmmo, ammoAddition);
            LogAmmo(tempAmmo, ammoPickUpTag);
        }
        if (ammoPickUpTag == "ShotgunBullet")
        {
            ShotgunAmmo tempAmmo = (ShotgunAmmo)inventory.itemPlayerList[ammoPickUpTag];
            AddAmmo(tempAmmo, ammoAddition);
            LogAmmo(tempAmmo, ammoPickUpTag);
        }
        if (ammoPickUpTag == "RifleBullet")
        {
            RifleAmmo tempAmmo = (RifleAmmo)inventory.itemPlayerList[ammoPickUpTag];
            AddAmmo(tempAmmo, ammoAddition);
            LogAmmo(tempAmmo, ammoPickUpTag);
        }
        Destroy(gameObject);
    }

    void AddAmmo(AmmoClass ammoClass, int additionCount)
    {
        ammoClass.Quantity += additionCount;
    }

    void LogAmmo(AmmoClass ammoClass, string ammoTag)
    {
        Debug.Log($"У вас стало {ammoClass.Quantity} патронов типа {ammoTag}");
    }
}

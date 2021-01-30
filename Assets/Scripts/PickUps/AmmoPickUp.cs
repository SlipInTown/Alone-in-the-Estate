using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickUp : MonoBehaviour
{
    [SerializeField] private string playerTag = "Player";
    [SerializeField] private int ammoAddition = 5;
    [SerializeField] private string ammoPickUpTag;

    private PlayeryInventory inventory;

    private void Start()
    {
        inventory = FindObjectOfType<PlayeryInventory>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag(playerTag)) return;

        var tempAmmo = (AmmoClass)inventory.GetItem(ammoPickUpTag);

        AddAmmo(tempAmmo, ammoAddition);

        LogAmmo(tempAmmo, ammoPickUpTag);

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

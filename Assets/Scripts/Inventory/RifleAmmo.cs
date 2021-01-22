using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RifleAmmo : MonoBehaviour, AmmoClass
{
    [SerializeField] private string ammoTag = "PistolBullet";

    [SerializeField] private int ammoCount = 0;

    [SerializeField] private float ammoDamage = 5f;

    public string AmmoType
    {
        get
        {
            return ammoTag;
        }
        set
        {
            ammoTag = value;
        }
    }

    public int Quantity
    {
        get
        {
            return ammoCount;
        }
        set
        {
            ammoCount = value;
        }
    }

    public float DamageOfAmmo
    {
        get
        {
            return ammoDamage;
        }
        set
        {
            ammoDamage = value;
        }
    }

    RifleAmmo rifleAmmo;
    void Start()
    {
        PlayerInvent inventory = GetComponent<PlayerInvent>();
        rifleAmmo = new RifleAmmo { AmmoType = ammoTag, Quantity = ammoCount, DamageOfAmmo = ammoDamage };
        inventory.itemPlayerList.Add(AmmoType, rifleAmmo);
    }

    public string GetItemType()
    {
        return AmmoType;
    }
}

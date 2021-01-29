using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotgunAmmo : MonoBehaviour, AmmoClass
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

    ShotgunAmmo shotgunAmmo;
    void Awake()
    {
        PlayerInvent inventory = GetComponent<PlayerInvent>();
        shotgunAmmo = new ShotgunAmmo { AmmoType = ammoTag, Quantity = ammoCount, DamageOfAmmo = ammoDamage };
        inventory.itemPlayerList.Add(AmmoType, shotgunAmmo);
    }

    public string GetItemType()
    {
        return AmmoType;
    }
}

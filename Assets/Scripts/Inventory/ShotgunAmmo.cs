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
    }

    public int AmmoCount
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
    }

    ShotgunAmmo shotGunAmmo;
    void Start()
    {
        shotGunAmmo = new ShotgunAmmo();
        FindObjectOfType<PlayerInvent>().itemPlayerList.Add(AmmoType, shotGunAmmo);
    }

    public string GetItemType()
    {
        return AmmoType;
    }
}

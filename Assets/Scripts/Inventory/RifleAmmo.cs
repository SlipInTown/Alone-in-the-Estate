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

    RifleAmmo rifleAmmo;
    void Start()
    {
        rifleAmmo = new RifleAmmo();
        FindObjectOfType<PlayerInvent>().itemPlayerList.Add(AmmoType, rifleAmmo);
    }

    public string GetItemType()
    {
        return AmmoType;
    }
}

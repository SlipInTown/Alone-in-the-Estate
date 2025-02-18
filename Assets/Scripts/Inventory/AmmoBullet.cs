﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBullet : MonoBehaviour , AmmoClass
{
    [SerializeField] private string ammoTag = "Bullet";

    [SerializeField] private int ammoCount = 0;

    [SerializeField] private float ammoDamage = 5f;

    public string AmmoType{ 
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

    AmmoBullet pistolAmmo;
    void Start()
    {
        PlayeryInventory inventory = GetComponent<PlayeryInventory>();
        pistolAmmo = new AmmoBullet { AmmoType = ammoTag, Quantity = ammoCount, DamageOfAmmo = ammoDamage };
        inventory.AddToInventory(AmmoType, pistolAmmo);
    }

    public string GetItemType()
    {
        return AmmoType;
    }
}

enum MyEnum
{

}
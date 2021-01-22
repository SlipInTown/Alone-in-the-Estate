using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInvent : MonoBehaviour
{
    //public static int pistolAmmoCount = 10;

    public Dictionary<string, IItem> itemPlayerList;
    
    void Start()
    {
        itemPlayerList = new Dictionary<string,IItem>();
    }


    //bool IsAmmoEnough()
    //{

    //}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface AmmoClass : IItem 
{
    string AmmoType{ get; }

    float DamageOfAmmo{ get; }

    int AmmoCount { get; set; }

}

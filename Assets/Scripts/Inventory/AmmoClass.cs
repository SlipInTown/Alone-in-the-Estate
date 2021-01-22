using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface AmmoClass : IItem 
{
    string AmmoType{ get; set; }

    float DamageOfAmmo{ get; set; }

}

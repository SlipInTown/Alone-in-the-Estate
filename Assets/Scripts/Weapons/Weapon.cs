using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface Weapon
{
    int weaponDamage{ get; set; }

    int roundMag{ get; set; }

    float reloadSpeed{ get; set; }

    string nameWeapon { get; set; }

    void Shoot();
}

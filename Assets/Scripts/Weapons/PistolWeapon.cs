using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolWeapon : MonoBehaviour
{
    [SerializeField] public int weaponDamage = 10;
    [SerializeField] public int roundMag = 10;
    [SerializeField] public float reloadSpeed;
    [SerializeField] public string nameWeapon = "Pistol";
    private string ammoTag = "PistolBullet";
    private PistolBullet bullet;

    ObjectPooler objectPooler;

    private void Start()
    {
        objectPooler = ObjectPooler.Instance;
        PlayerInput.MouseZeroInput += Shoot;
    }
    public void Shoot(bool isShoot)
    {
        if (isShoot)
        {
            if (PlayerInvent.pistolAmmoCount > 0){
                objectPooler.SpawnFromPool(ammoTag, RayCast.hitRayCast.point, Quaternion.LookRotation(transform.forward));
                PlayerInvent.pistolAmmoCount--;
                Debug.Log($"Осталось {PlayerInvent.pistolAmmoCount} патронов");
            }
            else Debug.Log($"У вас закончились патроны подберите новые!");
        }
        //if (isShoot) objectPooler.SpawnFromPool(ammoTag, transform.position, Quaternion.LookRotation(transform.forward));
    }
}

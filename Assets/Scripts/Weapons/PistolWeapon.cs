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

    AmmoClass ammunition;

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
            //if ()
            //{
            //    objectPooler.SpawnFromPool(ammoTag, RayCast.hitRayCast.point, Quaternion.LookRotation(transform.forward));
            //    PlayerInvent.pistolAmmoCount--;
            //}
                
            // Занести в Делегат Debug.Log($"Осталось {PlayerInvent.pistolAmmoCount} патронов");
            // Занести в Делегат else Debug.Log($"У вас закончились патроны подберите новые!");
        }
        //if (isShoot) objectPooler.SpawnFromPool(ammoTag, transform.position, Quaternion.LookRotation(transform.forward));
    }
}

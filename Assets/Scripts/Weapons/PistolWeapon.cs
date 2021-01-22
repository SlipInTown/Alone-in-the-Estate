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
    private PlayerInvent inventory;
    private PistolAmmo tempAmmo;

    AmmoClass ammunition;

    ObjectPooler objectPooler;

    private void Start()
    {
        objectPooler = ObjectPooler.Instance;
        PlayerInput.MouseZeroInput += Shoot;
        inventory = FindObjectOfType<PlayerInvent>();
    }
    public void Shoot(bool isShoot)
    {
        if (isShoot)
        {
            if (inventory.itemPlayerList[ammoTag].Quantity>0)
            { 
                objectPooler.SpawnFromPool(ammoTag, RayCast.hitRayCast.point, Quaternion.LookRotation(transform.forward));
                inventory.itemPlayerList[ammoTag].Quantity--;
                Debug.Log($"Осталось {inventory.itemPlayerList[ammoTag].Quantity} патронов");
            }
            //Занести в Делегат Debug.Log($"Осталось {PlayerInvent.pistolAmmoCount} патронов");
            //Занести в Делегат else Debug.Log($"У вас закончились патроны подберите новые!");
            else
            {
                Debug.Log($"У вас закончились патроны подберите новые!");
            }
        }
    }
}

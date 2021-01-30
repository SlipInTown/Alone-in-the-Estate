using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolWeapon : MonoBehaviour
{
    [SerializeField] private int weaponDamage = 10;
    [SerializeField] private int roundMag = 10;
    [SerializeField] private float reloadSpeed;
    [SerializeField] private string nameWeapon = "Pistol";
    private string ammoTag = "PistolBullet";
    [SerializeField] private PlayeryInventory inventory;

    private RayCast ray;

    [SerializeField] private ObjectPooler objectPooler;

    private void Awake()
    {
        ray = GetComponent<RayCast>();
    }
    public void Shoot(bool isShoot)
    {
        if (isShoot)
        {
            if (inventory.GetQuantityOfItem(ammoTag) > 0)
            { 
                objectPooler.SpawnFromPool(ammoTag, ray.Hit.point, Quaternion.LookRotation(transform.forward));
                inventory.DecreaseItem(ammoTag,1);
                Debug.Log($"Осталось {inventory.GetQuantityOfItem(ammoTag)} патронов");
            }
            //Занести в Делегат Debug.Log($"Осталось {PlayerInvent.pistolAmmoCount} патронов");
            //Занести в Делегат else Debug.Log($"У вас закончились патроны подберите новые!");
            //Перенести стрельбу по времени в корутины
            else
            {
                Debug.Log($"У вас закончились патроны подберите новые!");
            }
        }
    }
}

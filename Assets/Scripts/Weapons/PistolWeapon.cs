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
    private PlayerInvent inventory;

    private RayCast ray;

    ObjectPooler objectPooler;

    private void Start()
    {
        ray = GetComponent<RayCast>();
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
                objectPooler.SpawnFromPool(ammoTag, ray.Hit.point, Quaternion.LookRotation(transform.forward));
                inventory.itemPlayerList[ammoTag].Quantity--;
                Debug.Log($"Осталось {inventory.itemPlayerList[ammoTag].Quantity} патронов");
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

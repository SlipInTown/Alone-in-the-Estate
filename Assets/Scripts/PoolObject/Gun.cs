//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Gun : MonoBehaviour
//{
//    ObjectPooler objectPooler;

//    private void Start()
//    {
//        objectPooler = ObjectPooler.Instance;
//        PlayerInput.MouseZeroInput += Shoot;
//    }
//    public void Shoot(bool shoot)
//    {
//        if (shoot)
//        {
//            objectPooler.SpawnFromPool("Bullet", transform.position, Quaternion.identity);
//        }
//    }
//}

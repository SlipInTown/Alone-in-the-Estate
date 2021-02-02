using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private GameObject owner;
    
    [SerializeField] private int hpCount = 3;
    
    [SerializeField] private string enemyTag = "Enemy";

    [SerializeField] private EnemyManager enemyManager;
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag(enemyTag)) return;
        collision.gameObject.SetActive(false);
        hpCount--;
        if (hpCount == 0) { enemyManager.NumberOfEnemies = 0; }
    }
}

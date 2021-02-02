using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private GameObject owner;

    [SerializeField] private int hpCount = 3;

    private GameObject isAlreadyCollided = null;

    [SerializeField] private string bulletTag = "PistolBullet";

    private EnemyManager enemyManager;

    private void Start()
    {
        enemyManager = GetComponentInParent<EnemyManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag(bulletTag)) return;
        if ((isAlreadyCollided != null) && (isAlreadyCollided == collision.gameObject)) return;
        isAlreadyCollided = collision.gameObject;
        hpCount--;
        if (hpCount == 0) { enemyManager.NumberOfEnemies--; owner.SetActive(false); }
    }
}

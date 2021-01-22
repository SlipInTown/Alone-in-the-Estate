using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private GameObject owner;
    
    [SerializeField] private int hpCount = 3;
    
    private GameObject isAlreadyCollided = null;
    
    [SerializeField] private string enemyTag = "Enemy";
    
    [SerializeField] private string bulletTag = "PistolBullet";

    /// <summary>
    /// Добавить новые тэги для новых пуль ||
    /// </summary>
    /// <param name="collision"></param>

    private void OnCollisionEnter(Collision collision)
    {
        if (!(collision.gameObject.CompareTag(bulletTag) || collision.gameObject.CompareTag(enemyTag))) return;
        if ((isAlreadyCollided != null) && (isAlreadyCollided == collision.gameObject)) return;
        isAlreadyCollided = collision.gameObject;
        hpCount--;
        if (hpCount==0) Destroy(owner);
    }
}

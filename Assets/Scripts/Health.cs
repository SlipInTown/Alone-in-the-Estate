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
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (!(collision.gameObject.CompareTag(bulletTag) || collision.gameObject.CompareTag(enemyTag))) return;
        if ((isAlreadyCollided != null) && (isAlreadyCollided == collision.gameObject)) return;
        isAlreadyCollided = collision.gameObject;
        hpCount--;
        if (hpCount==0) Destroy(owner);
    }
}

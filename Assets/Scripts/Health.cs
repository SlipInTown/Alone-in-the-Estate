using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private GameObject owner;
    [SerializeField] private int hpCount = 3;
    private GameObject isAlreadyCollided = null; 
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (!(collision.gameObject.CompareTag("PistolBullet") || collision.gameObject.CompareTag("Ball"))) return;
        if ((isAlreadyCollided != null) && (isAlreadyCollided == collision.gameObject)) return;
        isAlreadyCollided = collision.gameObject;
        hpCount--;
        if (hpCount==0) Destroy(owner);
    }
}

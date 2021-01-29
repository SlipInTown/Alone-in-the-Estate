using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> enemiesArray;

    [SerializeField] private int numOfEnemies = 0;

    public int NumberOfEnemies
    {
        get
        {
            return numOfEnemies;
        }
        set
        {
            numOfEnemies = value;
        }
    }

    [SerializeField] private string nameOfScene = "Alone In the Estate";

    private void Start()
    {
        numOfEnemies = enemiesArray.Count;
        StartCoroutine(CoroutineEnemyCheck());
    }
    private IEnumerator CoroutineEnemyCheck()
    {
        bool temp = true;
        while (temp)
        {
            if (numOfEnemies == 0) { temp = false; }
            yield return new WaitForSeconds(1);
        }
        SceneManager.LoadScene(nameOfScene);
    }
}

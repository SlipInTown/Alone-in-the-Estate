using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolSetup : MonoBehaviour //обертка для управления статическим классом PoolManager
{
    #region Unity scene settings
    [SerializeField] private PoolManager.PoolPart[] pools; //структуры, где пользователь задает префаб для пула и количество элементов в пуле
    #endregion

    #region Methods
    void OnValidate()
    {
        for (int i = 0; i < pools.Length; i++)
        {
            pools[i].name = pools[i].prefab.name; //присваиваем имя заранее, до инициализации
        }
    }
    void Awake()
    {
        Initialize();    
    }

    void Initialize()
    {
        PoolManager.Initialize(pools);
    }
    #endregion
}

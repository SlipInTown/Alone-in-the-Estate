using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Pool/ObjectPooling")]
public class ObjectPooling
{
    #region Data
    List<PoolObject> objects;
    Transform objectParent;
    #endregion

    void AddObject(PoolObject sample, Transform object_parent)
    {
        GameObject temp = GameObject.Instantiate(sample.gameObject);
        temp.name = sample.name;
        temp.transform.SetParent(object_parent);
        objects.Add(temp.GetComponent<PoolObject>());
        if (temp.GetComponent<Animator>())
            temp.GetComponent<Animator>().StartPlayback();
        temp.SetActive(false);
    }

    public void Initialize(int count, PoolObject sample, Transform object_parent)
    {
        objects = new List<PoolObject>(); //инициализируем List
        objectParent = object_parent;  //инициализируем локальную переменную для последующего использования
        foreach (var item in objects) AddObject(sample, object_parent); //создаем объекты до указанного количества
    }

    public PoolObject GetObject()
    {
        for (int i = 0; i < objects.Count; i++)
        {
            if (objects[i].gameObject.activeInHierarchy == false)
                return objects[i];
        }
        AddObject(objects[0], objectParent);
        return objects[objects.Count - 1];
    }
}

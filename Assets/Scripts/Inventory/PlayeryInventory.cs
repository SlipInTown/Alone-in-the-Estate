using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeryInventory : MonoBehaviour
{
    [SerializeField] private Dictionary<string, IItem> itemPlayerList;
    
    void Awake()
    {
        itemPlayerList = new Dictionary<string,IItem>();
    }

    public void AddToInventory(string tag, IItem obj)
    {
        itemPlayerList.Add(tag, obj);
    }

    public int GetQuantityOfItem(string tag)
    {
        return itemPlayerList[tag].Quantity;
    }

    public void DecreaseItem(string tag, int num)
    {
        itemPlayerList[tag].Quantity = itemPlayerList[tag].Quantity - num;
    }

    public IItem GetItem(string tag)
    {
        return itemPlayerList[tag];
    }
}

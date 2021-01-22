using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IItem
{
    string GetItemType();

    int Quantity { get; set; }
}

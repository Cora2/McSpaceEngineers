using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ComponentObject : ItemObject
{
    public int Integrity;
    public int BaseProductionTime; // seconds
    public void Awake()
    {
        type = ItemType.Component;
    }
}

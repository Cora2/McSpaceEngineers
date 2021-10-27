using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Material", menuName = "Inventory System/Items/Material")]
public class MaterialObject : ItemObject
{
    public OreObject Ore;
    public float OreAmount;
    public void Awake()
    {
        type = ItemType.Component;
        Mass = 1;
    }
}

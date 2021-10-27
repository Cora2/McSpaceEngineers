using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Ore", menuName = "Inventory System/Items/Ore")]
public class OreObject : ItemObject
{
    private void Awake()
    {
        type = ItemType.Ore;
        Mass = 1;
    }
}

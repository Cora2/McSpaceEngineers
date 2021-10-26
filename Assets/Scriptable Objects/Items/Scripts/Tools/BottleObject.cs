using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Bottle Object", menuName = "Inventory System/Items/Tools/Bottle")]
public class BottleObject : ItemObject
{
    public int BaseProductionTime; // seconds
    public int GasCapacity; // Liters
    private void Awake()
    {
        type = ItemType.Tool;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Component", menuName = "Inventory System/Items/Component")]
public class ComponentObject : ItemObject
{
    public int Integrity;
    public int BaseProductionTime; // seconds
    public Object[][] Materials;
    public void Awake()
    {
        type = ItemType.Component;
    }
}

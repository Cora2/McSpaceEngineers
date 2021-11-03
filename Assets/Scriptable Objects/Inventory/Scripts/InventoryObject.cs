using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory System/Inventory")]
public class InventoryObject : ScriptableObject
{
    public List<InventorySlot> Container = new List<InventorySlot>();
    
    public void AddItem(ItemObject _item, float _amount)
    {
        bool hasItem = false;
        for (int i = 0; i < Container.Count; i++)
        {
            if (Container[i].item == _item)
            {
                Container[i].AddAmount(_amount);
                hasItem = true;
                break;
            }
        }
        if (!hasItem)
        {
            for (int i = 0; i < Container.Count; i++)
            {
                if (!Container[i].item)
                {
                    Container[i].item = _item;
                    Container[i].amount = _amount;
                    break;
                }
            }
        }
    }
}

[System.Serializable]
public class InventorySlot
{
    public ItemObject item;
    public float amount;
    public InventorySlot(ItemObject _item, float _amount)
    {
        item = _item;
        amount = _amount;
    }
    public void AddAmount(float value)
    {
        amount += value;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Tool,
    Weapon,
    Component,
    Ore,
    Material
}

// abstract basically means this is a base that gets inherited
public abstract class ItemObject : ScriptableObject
{
    public ItemType type;
    public GameObject prefab;
    public GameObject icon;
    public float Mass; // kilograms (kg)
    public float Volume; // Liters (L)
}

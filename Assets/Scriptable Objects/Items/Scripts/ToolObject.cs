using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ToolObject : ItemObject
{
    public int BaseProductionTime; // seconds
    public int DistanceMultiplier; // percent
    public int SpeedMultiplier; // percent
    public int DamageToPlayer;
    public int DamageToBlocks;
    public void Awake()
    {
        type = ItemType.Tool;
    }
}

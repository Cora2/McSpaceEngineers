using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Hand Drill Object", menuName = "Inventory System/Items/Tools/Hand Drill")]
public class HandDrillObject : ToolObject
{
    private void Awake()
    {
        Mass = 22;
        Volume = 25;
    }
}

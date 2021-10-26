using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Grinder Object", menuName = "Inventory System/Items/Tools/Grinder")]
public class GrinderObject : ToolObject
{
    private void Awake()
    {
        Mass = 3;
        Volume = 20;
    }
}

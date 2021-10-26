using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New  Welder Object", menuName = "Inventory System/Items/Tools/Welder")]
public class WelderObject : ToolObject
{
    private void Awake()
    {
        Mass = 5;
        Volume = 8;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityIndicator : MonoBehaviour
{
    public float gravityDirection = 90;

    void Update()
    {
        if (Mathf.Round(transform.rotation.eulerAngles.z) == gravityDirection) { Debug.Log("Gravity Indicator Paused"); }
        else
        {
            this.transform.eulerAngles = new Vector3(0, 0, gravityDirection);
            Debug.Log("Gravity Indicator moving");
        }   
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    public GameObject Inventoryobj;
    public bool hand = true;
    public void leftHand() {
        Debug.Log("Left Hand Selected");
        hand = true; 
    }
    public void rightHand() {
        Debug.Log("Right Hand Selected");
        hand = false; 
    }

    void Update() {
        if (Input.GetKeyDown("i")) {
            if (Inventoryobj.activeSelf) {
                Inventoryobj.SetActive(false);
            }
            else {
                Inventoryobj.SetActive(true);
            }
        }
        // if (Input.GetKeyDown("f"))
        // {
        //     if (hand == true) {
        //         rightHand();
        //     }
        //     else if (hand == false) {
        //         leftHand();
        //     }
        // }
        // if (hand == true) {
        //     Debug.Log("LEFT" + hand);
        // }
        // else if (hand == false) {
        //     Debug.Log("RIGHT" + hand);
        // }
        //NO IDEA WHAT THE FUCK IS GOING ON
    }
}

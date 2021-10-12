using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public float walkSpeed = 10f;
    public float jetpackSpeed = 75;
    public bool jetpack = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("j") && jetpack == false)
        {
            Debug.Log("Jetpack On");
            jetpack = true;
        }
        else if (Input.GetKeyDown("j"))
        {
            Debug.Log("Jetpack Off");
            jetpack = false;
        }

        if (jetpack == false)
        {
            this.GetComponent<Rigidbody2D>().gravityScale = 1;
            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
            transform.position += move * walkSpeed * Time.deltaTime;
        }
        else {
            this.GetComponent<Rigidbody2D>().gravityScale = 0;
            if (Input.GetKey("q"))
            {
                Debug.Log("Rotate Left");
                transform.Rotate(new Vector3(0f, 0f, 0.1f));
            }
            else if (Input.GetKey("e"))
            {
                Debug.Log("Rotate Left");
                transform.Rotate(new Vector3(0f, 0f, -0.1f));

            }
            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
            transform.position += move * walkSpeed * Time.deltaTime;
        }
    }
}

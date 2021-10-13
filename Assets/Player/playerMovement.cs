using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public float walkSpeed = 10f;
    public float jetpackSpeed = 75f;
    public bool jetpack = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("j") && jetpack == false)
        {
            Debug.Log("Jetpack On");
            jetpack = true;
            Vector3 stopmove = new Vector3(0, 0, 0);
            transform.position += stopmove;
            this.GetComponent<Rigidbody2D>().gravityScale = 1;
        }
        else if (Input.GetKeyDown("j"))
        {
            this.GetComponent<Rigidbody2D>().gravityScale = 0;
            Debug.Log("Jetpack Off");
            jetpack = false;
            Vector3 stopmove = new Vector3(0, 0, 0);
            transform.position += stopmove;
        }
        else {
            if (jetpack == false)
            {
                Vector3 jetpackmove = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
                transform.position += jetpackmove * walkSpeed * Time.deltaTime;
            }
            else {
                if (Input.GetKey("q"))
                {
                    Debug.Log("Rotate Left");
                    transform.Rotate(new Vector3(0f, 0f, 0.2f));
                }
                else if (Input.GetKey("e"))
                {
                    Debug.Log("Rotate Left");
                    transform.Rotate(new Vector3(0f, 0f, -0.2f));

                }
                Vector3 move = new Vector3(Input.GetAxis("Hoizontal"), Input.GetAxis("Vertical"), 0);
                transform.position += move * jetpackSpeed * Time.deltaTime;
            }
        }
    }
}

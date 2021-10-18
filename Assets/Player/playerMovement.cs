using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    //Movement
    public float walkSpeed = 10f;
    public float jetpackSpeed = 75f;
    public bool jetpack = false;
    void Update()
    {
        if (Input.GetKeyDown("j") && jetpack == false)
        {
            Debug.Log("Jetpack On");
            jetpack = true;
            Vector3 stopmove = new Vector3(0, 0, 0);
            transform.position += stopmove;
        }
        else if (Input.GetKeyDown("j"))
        {
            Debug.Log("Jetpack Off");
            jetpack = false;
            Vector3 stopmove = new Vector3(0, 0, 0);
            transform.position += stopmove;
        }
        else {
            if (jetpack == false)
            {
                //Jetpack off 
                this.GetComponent<Rigidbody2D>().gravityScale = 1;
                if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0) {
                    Vector3 jetpackmove = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
                    transform.position += jetpackmove * jetpackSpeed * Time.deltaTime;
                }
            }
            else {
                //Jetpack on
                this.GetComponent<Rigidbody2D>().gravityScale = 0;
                if (Input.GetKey("q")){transform.Rotate(new Vector3(0f, 0f, 0.3f));}
                else if (Input.GetKey("e")){transform.Rotate(new Vector3(0f, 0f, -0.3f));}

                if (Input.GetAxis("Horizontal") > 0){this.GetComponent<Rigidbody2D>().velocity = transform.right * jetpackSpeed;}
                else if ((Input.GetAxis("Horizontal") < 0)){this.GetComponent<Rigidbody2D>().velocity = -transform.right * jetpackSpeed;}

                if (Input.GetAxis("Vertical") > 0) {this.GetComponent<Rigidbody2D>().velocity = transform.up * jetpackSpeed;}
                else if (Input.GetAxis("Vertical") < 0) {this.GetComponent<Rigidbody2D>().velocity = -transform.up * jetpackSpeed;}
            }
        }
    }
    //Hud Stuff
    void Start()
    {
        SceneManager.LoadScene("HUD", LoadSceneMode.Additive);
    }
}

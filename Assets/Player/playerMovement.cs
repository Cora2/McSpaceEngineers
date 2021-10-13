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
                this.GetComponent<Rigidbody2D>().gravityScale = 1;
                if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0) {
                    Vector3 jetpackmove = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
                    transform.position += jetpackmove * jetpackSpeed * Time.deltaTime;
                }
                else {
                    Vector3 stopmove = new Vector3(0, 0, 0);
                    transform.position += stopmove;
                }
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
                if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0) {
                    Vector3 walkmove = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
                    transform.position += walkmove * walkSpeed * Time.deltaTime;
                }
                else {
                    Vector3 stopmove = new Vector3(0, 0, 0);
                    transform.position += stopmove;
                }
            }
        }
    }
    //Hud Stuff
    void Start()
    {
        SceneManager.LoadScene("HUD", LoadSceneMode.Additive);
    }
}

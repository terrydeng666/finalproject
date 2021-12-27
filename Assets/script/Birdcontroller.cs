using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Birdcontroller : MonoBehaviour
{
   
    Rigidbody rb;
    public Text gameover;
    public bool alive=true;
    //private CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameover.enabled = false;
        //controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (alive)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(600 * Vector3.up);
                //transform.localPosition += 2 * Vector3.up;
            }
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "CylinderUp" || 
            collision.transform.name == "CylinderDown")
        {
            Debug.Log(collision.transform.name);
            gameover.enabled = true;
            alive = false;
        }
    }
    /*void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log("GameOver2");
        gameover.enabled = true;
        alive = false;
    }*/
}

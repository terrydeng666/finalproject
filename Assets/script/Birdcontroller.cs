using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Birdcontroller : MonoBehaviour
{
    public Text gameover;
    public bool alive=true;
    private CharacterController controller;
    private Vector3 playerVelocity = Vector3.zero;
    public float speed;
    public float flySpeed;
    // Start is called before the first frame update
    void Start()
    {
        gameover.enabled = false;
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (alive)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                playerVelocity.y += flySpeed;
            }
            playerVelocity.y += Physics.gravity.y * Time.deltaTime;//v=v0+gt
            controller.Move(playerVelocity * Time.deltaTime);//s=v*t
            controller.Move(transform.forward * speed * Time.deltaTime);
        }
        else
        {
            controller.SimpleMove(Vector3.zero);//with gravity
        }
    }
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log(hit.gameObject.name);
        if (hit.gameObject.tag == "tube")
        {
            alive = false;
        }
        if(hit.gameObject.name == "Plane")
        {
            alive = false;
            gameover.enabled = true;
        }
    }
}

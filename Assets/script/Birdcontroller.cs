using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Birdcontroller : MonoBehaviour
{
    public Text gameover;
    public Material glowMaterial;
    public Material normalMaterial;
    public bool alive = true;
    private CharacterController controller;
    private Vector3 playerVelocity = Vector3.zero;
    private int aliveTime = 3;
    private bool invincible = false;
    private MeshRenderer msRender;
    public float speed;
    public float flySpeed;
    // Start is called before the first frame update
    void Start()
    {
        gameover.enabled = false;
        controller = GetComponent<CharacterController>();
        GameObject cube = controller.transform.GetChild(0).gameObject;
        msRender = cube.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= 85.0f || transform.position.y <= 0) {
            alive = false;
            gameover.enabled = true;
            return;
        }
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
        if (invincible) {
            return;
        }
        // Debug.Log(hit.gameObject.name);
        if (hit.gameObject.tag == "tube")
        {
            alive = false;
            gameover.enabled = true;
        }
    }

    public void noOneCanBeat() {
        msRender.material = glowMaterial;
        invincible = true;
        InvokeRepeating("timer", 1, 1);
    }

    private void timer() {
        Debug.Log("countdown");
        alive = true;
        aliveTime--;
        if (aliveTime == 0) {
            CancelInvoke("timer");
            msRender.material = normalMaterial;
            invincible = false;
            aliveTime = 3;
        }
    }
}

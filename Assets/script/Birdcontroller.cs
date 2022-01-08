using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Birdcontroller : MonoBehaviour
{
    public Text gameover;
    public AudioSource flySound;
    public AudioClip impact;
    public AudioSource eatSound;
    public AudioClip eatImpact;
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
    //public TextMeshProUGUI back;
    public Button back;
    public Button restart;
    int time = 0;
    bossController boss;
    bool flag = true;
    // Start is called before the first frame update
    void Start()
    {
        gameover.enabled = false;
        //ck.interactable = false;
        back.gameObject.SetActive(false);
        restart.gameObject.SetActive(false);
        controller = GetComponent<CharacterController>();
        GameObject cube = controller.transform.GetChild(0).gameObject;
        msRender = cube.GetComponent<MeshRenderer>();
        flySound = GetComponent<AudioSource>();
        boss = GameObject.FindObjectOfType<bossController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (boss.meetBoss && flag)
        {
            noOneCanBeat();
            controller.Move(transform.forward * 100);
            transform.position = new Vector3(transform.position.x, 0.0f, transform.position.z);
            flag = false;
        }
        if (time < 120)
        {
            if (time % 50 == 0)
            {
                playerVelocity.y += flySpeed;
            }
            playerVelocity.y += Physics.gravity.y * Time.deltaTime;//v=v0+gt
            controller.Move(playerVelocity * Time.deltaTime);//s=v*t
            controller.Move(transform.forward * speed * Time.deltaTime);
            time++;
            return;
        }
        if (transform.position.y >= 80.0f || transform.position.y <= -80.0f)
        {
            alive = false;
            gameover.enabled = true;
            //  back.interactable = true;
            back.gameObject.SetActive(true);
            restart.gameObject.SetActive(true);
            return;
        }
        if (alive)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                flySound.PlayOneShot(impact);
                playerVelocity.y += flySpeed;
            }
            playerVelocity.y += Physics.gravity.y * Time.deltaTime;//v=v0+gt
            controller.Move(playerVelocity * Time.deltaTime);//s=v*t
            if (!boss.meetBoss)
                controller.Move(transform.forward * speed * Time.deltaTime);
        }
        else
        {
            controller.SimpleMove(Vector3.zero);//with gravity
        }
    }
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (invincible)
        {
            return;
        }
        // Debug.Log(hit.gameObject.name);
        if (hit.gameObject.tag == "tube" || hit.gameObject.tag == "bullet")
        {
            alive = false;
            gameover.enabled = true;
            back.gameObject.SetActive(true);
            restart.gameObject.SetActive(true);
        }
    }

    public void noOneCanBeat()
    {
        eatSound.PlayOneShot(eatImpact);
        msRender.material = glowMaterial;
        invincible = true;
        InvokeRepeating("timer", 1, 1);
    }

    private void timer()
    {
        Debug.Log("countdown");
        alive = true;
        aliveTime--;
        if (aliveTime == 0)
        {
            CancelInvoke("timer");
            msRender.material = normalMaterial;
            invincible = false;
            aliveTime = 3;
        }
    }
}

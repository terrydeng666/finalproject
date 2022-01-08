using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bossController : MonoBehaviour
{
    private int score;
    addpoint addpoint;
    public RawImage boss;
    public bool meetBoss = false;
    tubespawner tubespawner;
    // Start is called before the first frame update
    void Start()
    {
        addpoint = GameObject.FindObjectOfType<addpoint>();
        tubespawner = GameObject.FindObjectOfType<tubespawner>();
        //boss = GetComponent<RawImage>();
        //boss.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (addpoint.point >= tubespawner.encounterboss)
        {
            //boss.enabled = true;
            meetBoss = true;
        }
    }
}

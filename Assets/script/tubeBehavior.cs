using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class tubeBehavior : MonoBehaviour
{
    private Vector3 start;
    private float i = 0.0f;
    private bool isRandom;
    private System.Random rnd = new System.Random(Guid.NewGuid().GetHashCode());
    bool flag;//up:true
    public float tubeMoveSpeed=0.08f;
    public float tubeMoveRange = 10.0f;
    void Start()
    {
        if (rnd.Next() % 3 == 0)
        {
            isRandom = true;
        }
        else
        {
            isRandom = false;
        }
        start = transform.position;
        flag = true;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (!isRandom)
        {
            return;
        }
        //i += 0.007f;
        //float l = Mathf.PingPong(i, 10);
        if(flag && i >= tubeMoveRange)
        {
            flag = false;
        }
        if(!flag && i <= -1*tubeMoveRange)
        {
            flag = true;
        }
        if (flag)
        {
            i += tubeMoveSpeed;
        }
        if (!flag)
        {
            i -= tubeMoveSpeed;
        }
        transform.position = new Vector3(transform.position.x, 0, transform.position.z) + i*Vector3.up;
    }
}

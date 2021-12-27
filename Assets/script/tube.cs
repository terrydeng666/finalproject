using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class tube : MonoBehaviour
{
    System.Random r = new System.Random();
    private Birdcontroller bird;
    // Start is called before the first frame update
    void Start()
    {
        transform.localPosition += r.Next(-20,20)* Vector3.up;
        bird = GameObject.FindObjectOfType<Birdcontroller>();
    }

    // Update is called once per frame
    void Update()
    {
        if (bird.alive)
        {
            transform.localPosition += float.Parse("0.1") * Vector3.back;
        }
    }
}

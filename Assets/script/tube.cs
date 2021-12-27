using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class tube : MonoBehaviour
{
    System.Random r = new System.Random();
    // Start is called before the first frame update
    void Start()
    {
        transform.localPosition += r.Next(-20,20)* Vector3.up;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += float.Parse("0.1") * Vector3.back;
    }
}

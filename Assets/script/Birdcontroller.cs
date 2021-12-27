using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdcontroller : MonoBehaviour
{
   
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(600 * Vector3.up);
            //transform.localPosition += 2 * Vector3.up;
        }
    }
}

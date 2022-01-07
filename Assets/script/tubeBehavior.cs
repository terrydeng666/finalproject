using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class tubeBehavior : MonoBehaviour{
    private Vector3 start;
    private float i = 0.0f;
    private bool isRandom;
    private System.Random rnd = new System.Random(Guid.NewGuid().GetHashCode());

    void Start() {
        if (rnd.Next() % 3 == 0) {
            isRandom = true;
        }
        else {
            isRandom = false;
        }
        start = transform.position;
    }

    // Update is called once per frame
    void Update(){
        if (!isRandom) {
            return;
        }
        i += 0.007f;
        float l = Mathf.PingPong(i, 10);
        transform.position = start + Vector3.up * l;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class tubespawner : MonoBehaviour
{
    System.Random r = new System.Random();
    public GameObject tube;
    int time=0;

    private Birdcontroller bird;

    // Start is called before the first frame update
    void Start()
    {
        bird = GameObject.FindObjectOfType<Birdcontroller>();
    }

    // Update is called once per frame
    void Update()
    {
        if (bird.alive)
        {
            time++;
            if (time == 500)
            {
                GameObject temp;
                transform.localPosition += r.Next(-3, 3) * Vector3.up;
                time = 0;
                temp = Instantiate(tube, transform.localPosition, transform.rotation);
                //temp.transform.localPosition += r.Next(-3, 3) * Vector3.up;
            }
        }
    }
}

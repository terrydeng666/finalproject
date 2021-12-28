using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class tubespawner : MonoBehaviour
{
    System.Random r = new System.Random();
    public GameObject tube;
    int time=0;
    public float timeOffset = 0.5f;
    private Birdcontroller bird;
    private Vector3 previousPosition;
    private float startTime;
    Vector3 spawnPos;
    public float distanceBetweenTubes = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        bird = GameObject.FindObjectOfType<Birdcontroller>();
        previousPosition = tube.transform.position;
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (bird.alive)
        {
            if (Time.time - startTime > timeOffset)
            {           
                startTime = Time.time;
                spawnPos = previousPosition + distanceBetweenTubes * new Vector3(0,0,1);
                Instantiate(tube, spawnPos, Quaternion.Euler(0, 0, 0));
                previousPosition = spawnPos;
            }
        }
    }
}

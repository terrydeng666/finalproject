using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class tubespawner : MonoBehaviour
{
    System.Random r = new System.Random();
    public GameObject tube;
    public GameObject tubeandboss;
    int time = 0;
    public float timeOffset = 0.5f;
    private Birdcontroller bird;
    private Vector3 previousPosition;
    private float startTime;
    Vector3 spawnPos;
    public float distanceBetweenTubes = 30.0f;
    int num = 0;
    public int encounterboss;
    bossController boss;
    // Start is called before the first frame update
    void Start()
    {
        bird = GameObject.FindObjectOfType<Birdcontroller>();
        previousPosition = tube.transform.position;
        startTime = Time.time;
        boss = GameObject.FindObjectOfType<bossController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (bird.alive)
        {
            if (Time.time - startTime > timeOffset && num < encounterboss)
            {
                startTime = Time.time;
                spawnPos = previousPosition + distanceBetweenTubes * new Vector3(0, 0, 1);
                Instantiate(tube, spawnPos, Quaternion.Euler(0, 0, 0));
                previousPosition = spawnPos;
                num++;
            }
            if (Time.time - startTime > timeOffset && num == encounterboss && boss.meetBoss)
            {
                startTime = Time.time;
                spawnPos = previousPosition + 130 * new Vector3(0, 0, 1);
                Instantiate(tubeandboss, spawnPos, Quaternion.Euler(0, 0, 0));
                previousPosition = spawnPos;
                num++;
            }
        }
    }
}

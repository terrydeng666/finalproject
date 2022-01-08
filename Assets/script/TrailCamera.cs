using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailCamera : MonoBehaviour
{
    public Transform target;
    public float trailDistance = 5.0f;
    public float heightOffset = 0.0f;
    public float cameraDelay = 1.0f;
    int time = 0;

    // Update is called once per frame
    void Update()
    {
        if (time > 120)
        {
            
             Vector3 followPos = target.position - target.forward * trailDistance;
             followPos.y += heightOffset;
             transform.position += (followPos - transform.position) * cameraDelay;
             transform.LookAt(target.transform);
        }
        time++;
    }
}
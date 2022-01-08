using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tubeandbosscontroller : MonoBehaviour
{
    public GameObject bullet;
    private float startTime;
    public float timeOffset = 5.0f;
    bool flag;//up:true
    public float tubeMoveSpeed = 0.08f;
    public float tubeMoveRange = 10.0f;
    private float i = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        flag = true;
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - startTime > timeOffset)
        {
            startTime = Time.time;

            //spawnPos = previousPosition + distanceBetweenTubes * new Vector3(0, 0, 1);
            Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(0, 0, 0));
            //previousPosition = spawnPos;
            //num++;
        }
        if (flag && i >= tubeMoveRange)
        {
            flag = false;
        }
        if (!flag && i <= -1 * tubeMoveRange)
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
        transform.position = new Vector3(transform.position.x, 0, transform.position.z) + i * Vector3.up;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletcontroller : MonoBehaviour
{
    Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        if (Random.value >= 0.67f)
        {
            direction = new Vector3(0, 1, -1);
        }
        else if (0.67f > Random.value && Random.value > 0.33f)
        {
            direction = new Vector3(0, 0, -1);
        }
        else
        {
            direction = new Vector3(0, -1, -1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z) + direction;
    }
}

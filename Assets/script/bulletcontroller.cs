using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletcontroller : MonoBehaviour
{
    Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        if (Random.value >= 0.8f)
        {
            direction = new Vector3(0, 1, -1);
        }
        else if (0.8f > Random.value && Random.value > 0.6f)
        {
            direction = new Vector3(0, 0.5f, -1);
        }
        else if (0.6f > Random.value && Random.value > 0.4f)
        {
            direction = new Vector3(0, 0, -1);
        }
        else if (0.4f > Random.value && Random.value > 0.2f)
        {
            direction = new Vector3(0, -0.5f, -1);
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class add_tube : MonoBehaviour
{
    addpoint a;
    // Start is called before the first frame update
    void Start()
    {
        a = GameObject.FindObjectOfType<addpoint>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
        a.add();
    }
}

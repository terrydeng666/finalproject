using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class tube : MonoBehaviour
{
    public GameObject chickenLeg;
    System.Random r = new System.Random();
    System.Random rnd = new System.Random(Guid.NewGuid().GetHashCode());

    // Start is called before the first frame update
    void Start()
    {
        transform.localPosition += r.Next(-10, 30) * Vector3.up;
        spawnCoins();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnCoins() {
        int r = rnd.Next();
        if (r % 10 <= 1) {
            return;
        }
        int coinsToSpawn = 1;
        for (int i = 0; i < coinsToSpawn; i++) {
            GameObject tmp = Instantiate(chickenLeg, transform);
            tmp.transform.position = getRndPoint(GetComponent<Collider>());
        }
    }

    Vector3 getRndPoint(Collider collider) {
        Vector3 point = new Vector3(
            UnityEngine.Random.Range(collider.bounds.min.x, collider.bounds.max.x),
            UnityEngine.Random.Range(collider.bounds.min.y, collider.bounds.max.y),
            UnityEngine.Random.Range(collider.bounds.min.z, collider.bounds.max.z)
        );
        if (point != collider.ClosestPoint(point)) {
            point = getRndPoint(collider);
        }

        point.y += 20;
        point.z -= 10;
        return point;
    }
}

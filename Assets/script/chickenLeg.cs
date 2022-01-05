using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chickenLeg : MonoBehaviour{

    public float turnSpeed = -90f;
    

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        transform.Rotate(0, turnSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other) {

        
        if (other.gameObject.name == "CylinderUp" || other.gameObject.name == "CylinderDown") {
            //Debug.Log(other.gameObject.name);
            Destroy(gameObject);
            return;
        }

        if (other.gameObject.name != "bird") {
            return;
        }
        
        Birdcontroller bird = other.GetComponent<Birdcontroller>();
        bird.noOneCanBeat();
        Destroy(this.gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chickenLeg : MonoBehaviour{

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
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

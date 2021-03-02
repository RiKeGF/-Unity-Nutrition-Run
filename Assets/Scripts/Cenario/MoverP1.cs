using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverP1 : MonoBehaviour {

    public GameObject cenarioP1;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider col) {

        if (col.transform.tag == "Player") {
            cenarioP1.transform.position = new Vector3(cenarioP1.transform.position.x, cenarioP1.transform.position.y, (cenarioP1.transform.position.z + (1400f * 5)));
        } 
    }
}

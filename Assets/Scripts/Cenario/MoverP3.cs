using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverP3 : MonoBehaviour {

    public GameObject cenarioP2;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    private void OnTriggerEnter(Collider col) {

        if (col.transform.tag == "Player") {
            cenarioP2.transform.position = new Vector3(cenarioP2.transform.position.x, cenarioP2.transform.position.y, (cenarioP2.transform.position.z + (1400f * 5)));
        }
    }
}

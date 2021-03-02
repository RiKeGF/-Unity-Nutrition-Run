using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public GameObject perso;


    void Start() {
    }

    void Update() {
        if (perso.transform.position.y < 35)
        {
            this.transform.position = new Vector3(perso.transform.position.x, perso.transform.position.y + 12f, perso.transform.position.z - 50f);
        }
        else if (perso.transform.position.y > 34)
        {
            this.transform.position = new Vector3(perso.transform.position.x, this.transform.position.y, perso.transform.position.z - 50f);
        }

    } 
}

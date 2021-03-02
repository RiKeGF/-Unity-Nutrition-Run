using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Filtro : MonoBehaviour {

    public GameObject perso;

    void Update() {

        this.transform.position = new Vector3(perso.transform.position.x, perso.transform.position.y, perso.transform.position.z - 45f);

    } 
}

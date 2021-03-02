using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escuro : MonoBehaviour {

    public GameObject perso; 

    void Update()
    {

        this.transform.position = new Vector3(perso.transform.position.x, perso.transform.position.y, perso.transform.position.z + 2400);

    }
}

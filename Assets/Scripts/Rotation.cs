using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (transform.tag == "GorduraPequena")
        {
            this.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else if (transform.tag == "GorduraMedia")
        {
            this.transform.localRotation = Quaternion.Euler(0, 90, 0);
        }
        else if (transform.tag == "GorduraGrande")
        {
            this.transform.localRotation = Quaternion.Euler(90, 0, 90);
        }
        else if (transform.tag == "Ferro" || transform.tag == "Phosforo" || transform.tag == "DP" || transform.tag == "DH" || transform.tag == "ATP")
        {
            this.transform.localRotation = Quaternion.Euler(180, 0, 180);
        }
        


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

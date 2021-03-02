using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (transform.tag == "GorduraPequena")
        {
            this.transform.localScale = new Vector3(Random.Range(0.1f, 0.3f), Random.Range(0.1f, 0.2f), 0.1f);
        }
        else if (transform.tag == "GorduraMedia")
        {
            this.transform.localScale = new Vector3(Random.Range(0.2f, 0.5f), Random.Range(0.2f, 0.5f), Random.Range(0.2f, 0.3f));
        }
        else if (transform.tag == "GorduraGrande")
        {
            this.transform.localScale = new Vector3(Random.Range(0.8f, 1.5f), Random.Range(0.8f, 1.5f), Random.Range(0.6f, 1f));
        }
        /*else if (transform.tag == "Inimigo")
        {
            this.transform.localScale = new Vector3(Random.Range(15f, 17f), 15, Random.Range(5f, 8f));
        }*/
        else if(transform.tag == "Proteinas" || transform.tag == "Carboidratos" || transform.tag == "Lipidios" || transform.tag == "H2O" || transform.tag == "Vitaminas" || transform.tag == "Vegetais")
        {
            this.transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
        }
        
	}
	
	// Update is called once per frame
	void Update () {
    
    }
}

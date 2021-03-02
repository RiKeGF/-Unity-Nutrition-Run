using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Destroy : MonoBehaviour {

    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


	}


    private void OnTriggerEnter(Collider col)
    {
        if (col.transform.tag == "Player")
        {
          
            Destroy(this.gameObject);
        }
        if(col.transform.tag == "Limite")
        {
            
            Destroy(this.gameObject);
        }
    }


}


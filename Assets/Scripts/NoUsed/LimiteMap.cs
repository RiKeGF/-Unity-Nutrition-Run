/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimiteMap : MonoBehaviour {

    float numeroPiso = 317f;
    


	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    private void OnTriggerEnter(Collider colisao)
    {
        if(colisao.transform.tag == "Limite")
        {
            float larguraObj = GetComponent<BoxCollider>().size.x;

            Vector3 posicao = GetComponent<BoxCollider>().transform.position;

            posicao.x += larguraObj * numeroPiso;

            GetComponent<BoxCollider>().transform.position = posicao;
        }

    }


}*/

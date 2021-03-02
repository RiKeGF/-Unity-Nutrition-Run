/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limitador : MonoBehaviour {

    public GameObject player;

    private Player sp;


	void Start () {
        sp = player.GetComponent<Player>();
        
	}
	void Update () {
		
	}

    private void OnTriggerEnter(Collider col) {
        if (col.transform.tag == "LimiteEsquerda") {
            sp.moverEsquerda = false;
        }
        if (col.transform.tag == "LimiteDireita") {
            sp.moverDireita = false;
        }
        if (col.transform.tag == "Chao") {
            sp.moverBaixo = false;
        }
        if (col.transform.tag == "Teto") {
            sp.moverCima = false;
        }
    }
    private void OnTriggerExit(Collider col) {
        if (col.transform.tag == "LimiteEsquerda") {
            sp.moverEsquerda = true;
        }
        if (col.transform.tag == "LimiteDireita") {
            sp.moverDireita = true;
        }
        if (col.transform.tag == "Chao") {
            sp.moverBaixo = true;
        }
        if (col.transform.tag == "Teto") {
            sp.moverCima = true;
        }
    }

}
*/
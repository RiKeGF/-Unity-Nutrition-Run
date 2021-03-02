using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointsDistance : MonoBehaviour {
    
    public GameObject spawnNutrientes;
    public GameObject perso;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        spawnNutrientes.transform.position = new Vector3(perso.transform.position.x + 100, spawnNutrientes.transform.position.y, spawnNutrientes.transform.position.z);
    }
}

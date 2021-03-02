using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girar : MonoBehaviour
{

   // Use this for initialization
   void Start()
   {

   }

   // Update is called once per frame
   void Update()
   {
        if (transform.tag == "GorduraPequena") {
            transform.Rotate(Vector3.up, -20 * Time.deltaTime);
            transform.Rotate(Vector3.left, -20 * Time.deltaTime);
        } else {
            transform.Rotate(Vector3.up, -100 * Time.deltaTime);
            //transform.Rotate(Vector3.left, -60 * Time.deltaTime);
        }
     



   }
}

/*using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class EXCoroutine : MonoBehaviour
{

    public float moveForce = 2f;
    public float maxSpeed = 2f;

    private float xForce = 2f;
    private float yForce = 1.7f;
    private float zForce = 3f;

    private Rigidbody rb;


    private bool estaVivo = true;


    public int vida = 3;
    public int Num_Ferro = 0;
    public int Num_Amido = 0;

    public Text Text_Ferro;
    public Text Text_Amido;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Text_Ferro.text = "Ferro: " + Num_Ferro.ToString();
        Text_Amido.text = "Amido: " + Num_Amido.ToString();
    }

    void Update()
    {
        
    }


    private void FixedUpdate()
    {
        //Personagem
        if (estaVivo)
        {
            rb.AddForce(Vector3.right * xForce * moveForce);

            if (rb.velocity.x > maxSpeed)
            {
                rb.velocity = new Vector2(Mathf.Sign(rb.velocity.x) * maxSpeed, rb.velocity.y);
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                StartCoroutine(MoverDir());

            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                StartCoroutine(MoverEsq());
            }

            if (Input.GetKey(KeyCode.Space))
            {
                StartCoroutine(Subir());
            }
        }
        //End Personagem
    }

    private IEnumerator MoverDir()
    {


        if (transform.position.z <= -2.8 && transform.position.z >= -3.2)
        {
            while (transform.position.z != -4.5f)
            {
                float step = zForce * Time.deltaTime;

                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y, -4.5f), step);
                
                yield return new WaitForSeconds(0.01f);
            }
        }

        if (transform.position.z <= -1.3 && transform.position.z >= -1.7)
        {
            while (transform.position.z != -3)
            {
                float step = zForce * Time.deltaTime;

                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y, -3), step);

                yield return new WaitForSeconds(0.01f);
            }
        }




        yield return null;
    }

    private IEnumerator MoverEsq()
    {


        if (transform.position.z <= -2.8 && transform.position.z >= -3.2)
        {
            while (transform.position.z != -1.5)
            {
                float step = zForce * Time.deltaTime;

                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y, -1.5f), step);

                yield return new WaitForSeconds(0.01f);
            }
        }

        if (transform.position.z <= -4.3 && transform.position.z >= -4.7)
        {
            while (transform.position.z != -3)
            {
                float step = zForce * Time.deltaTime;

                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y, -3), step);

                yield return new WaitForSeconds(0.01f);
            }
        }




        yield return null;
    }

    private IEnumerator Subir()
    {


        if (transform.position.y == 1)
        {

            if (transform.position.y != 2.5)
            {
                while (transform.position.y != 2.5)
                {
                    float step = yForce * Time.deltaTime;

                    transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, 2.5f, transform.position.z), step);

                    yield return new WaitForSeconds(0.01f);
                }
            }
            if (transform.position.y == 2.5)
            {
                while (transform.position.y != 1)
                {
                    float step = yForce * Time.deltaTime;

                    transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, 1, transform.position.z), step);

                    yield return new WaitForSeconds(0.01f);
                }
            }

        }


        yield return null;
    }


    private void OnTriggerEnter(Collider col)
    {
        if (col.transform.tag == "Ferro")
        {
            Num_Ferro++;
            Text_Ferro.text = "Ferro: " + Num_Ferro.ToString();
            Destroy(col.gameObject);
        }

        if (col.transform.tag == "Amido")
        {
            Num_Amido++;
            Text_Amido.text = "Amido: " + Num_Amido.ToString();
            Destroy(col.gameObject);
        }
    }

}
*/
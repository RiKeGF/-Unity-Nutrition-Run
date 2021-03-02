using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Player : MonoBehaviour
{
   public Image barra;
   public Image barraEnergia;

   public GameObject endUI;
   public GameObject hudUI;
   public Animator Info_Jogo;
   public Animator Info_Pause;
   public bool morreu;

   public float moveForce = 40;
   public float speed = 120;
   public float speedMax;
   public float moveForceY = 0;

   public int predominancia;

   public int Num_Pontos = 0;
   public int Num_Distancia = 0;

   private float dist_Percorrida;
   public float tempo_distPercorrida;
   private float tempo = 10f;

   private Spawn delaySpawnObj;

   private Pause pause;

   //private float delayCollision = 120f;

   public Text Text_Pontos;
   public Text Text_Distancia;
   public Text Text_Gordao;

   /*
   private Renderer veia;
   public GameObject[] pista = new GameObject[5];
   private float parallax = 0.02f;
   private float mettalic = 0.3f;
   private bool sobe;
   private bool desce;
   */

   public GameObject particula;
   public GameObject personagem;

   public AudioSource[] audios = new AudioSource[3];

   public bool isLive = true;

   void Start()
   {
      particula.SetActive(false);
      tempo_distPercorrida = 1f;
      endUI.SetActive(false);
      predominancia = Random.Range(1, 4);

      dist_Percorrida = tempo;

      speedMax = speed;

      Text_Pontos.text = Num_Pontos.ToString();
      Text_Distancia.text = Num_Distancia.ToString();

      delaySpawnObj = this.GetComponent<Spawn>();
      pause = GameObject.FindGameObjectWithTag("CanvasPause").GetComponent<Pause>();

      //StartCoroutine("luzVeia");
   }

   void Update()
   {
      Text_Gordao.text = delaySpawnObj.gordao.ToString();

      // delayCollision -= 10f;

      /*
      if (delayCollision <= 0)
      {
         delayCollisionObject();
      }
      */

      if (isLive)
      {
         if (!pause.pause)
         {
            dist_Percorrida -= tempo_distPercorrida;

            if (dist_Percorrida <= 0)
            {
               Text_Distancia.text = Num_Distancia.ToString();
               Num_Distancia++;
               dist_Percorrida = tempo;

            }
         }
      }



   }


   private void FixedUpdate()
   {
      if (isLive)
      {
         player();
      }
      //Eixos

      this.transform.Translate(0, 0, (speed * Time.deltaTime));

      //End Eixos
   }


   private void player()
   {
      //Personagem

      if (this.transform.position.x > -20 && Input.GetKey(KeyCode.LeftArrow))
      {

         this.transform.Translate((-moveForce * Time.deltaTime), 0, 0);

      }
      if (this.transform.position.x < 23 && Input.GetKey(KeyCode.RightArrow))
      {
         this.transform.Translate((moveForce * Time.deltaTime), 0, 0);

      }
      if (this.transform.position.y < 38 && Input.GetKey(KeyCode.UpArrow))
      {
         this.transform.Translate(0, ((moveForce - moveForceY) * Time.deltaTime), 0);

      }
      if (this.transform.position.y > 10 && Input.GetKey(KeyCode.DownArrow))
      {
         this.transform.Translate(0, (-(moveForce - moveForceY) * Time.deltaTime), 0);

      }
      //End Personagem     
   }
   /*
      void delayCollisionObject()
      {
         if (speed < speedMax)
         {
            speed += 5;
            delayCollision = 100f;
         }

      }
      */


   /*private IEnumerator luzVeia()
   {
      if (sobe)
      {
         if (parallax <= 0.08)
         {
            parallax += 0.01f;
            yield return new WaitForSeconds(0.1f);
         }

         if (mettalic <= 0.8f)
         {
            mettalic += 0.05f;
            yield return new WaitForSeconds(0.1f);
         }
      }

      if (desce)
      {
         if (parallax >= 0.02)
         {
            parallax -= 0.001f;
            yield return new WaitForSeconds(0.1f);
         }

         if (mettalic >= 0.2f)
         {
            mettalic -= 0.01f;
            yield return new WaitForSeconds(0.1f);
         }
      }


      if (parallax >= 0.08f && mettalic >= 0.8f)
      {
         sobe = false;
         desce = true;
      }
      else if (parallax <= 0.02f && mettalic <= 0.2f)
      {
         sobe = true;
         desce = false;
      }


      for (int i = 0; i < pista.Length; i++)
      {
         pista[i].GetComponent<Renderer>().material.SetFloat("_Parallax", parallax);
         pista[i].GetComponent<Renderer>().material.SetFloat("_Metallic", mettalic);

      }

      StartCoroutine("luzVeia");
   }*/

   private void OnCollisionEnter(Collision col)
   {
      if (col.transform.tag == "GorduraPequena" || col.transform.tag == "GorduraMedia" || col.transform.tag == "GorduraGrande")
      {
         isLive = false;
         StartCoroutine("morte");
      }

   }

   private IEnumerator morte()
   {     
      audios[4].Stop();
      audios[1].Play();
      Destroy(personagem.gameObject);
      particula.SetActive(true);
      audios[2].Play();
      yield return new WaitForSeconds(1.5f);

      morreu = true;
      //hudUI.SetActive(false);
      particula.SetActive(false);
      endUI.SetActive(true);
      barra.enabled = false;
      barraEnergia.enabled = false;
      Text_Gordao.enabled = false;

      audios[3].Play();
      Time.timeScale = 0;

   }

   private void OnTriggerEnter(Collider col)
   {


      if (col.transform.tag == "Carboidratos")
      {
         audios[0].Play();
         Num_Pontos += 20;
         delaySpawnObj.gordao -= 20f;
         Text_Pontos.text = Num_Pontos.ToString();
         Destroy(col.gameObject);
      }
      else if (col.transform.tag == "H2O")
      {
         audios[0].Play();
         Num_Pontos += 15;
         delaySpawnObj.gordao -= 15f;
         Text_Pontos.text = Num_Pontos.ToString();
         Destroy(col.gameObject);
      }
      else if (col.transform.tag == "Vitaminas")
      {
         audios[0].Play();
         Num_Pontos += 12;
         delaySpawnObj.gordao -= 12f;
         Text_Pontos.text = Num_Pontos.ToString();
         Destroy(col.gameObject);
      }
      else if (col.transform.tag == "Vegetais")
      {
         audios[0].Play();
         Num_Pontos += 10;
         delaySpawnObj.gordao -= 10f;
         Text_Pontos.text = Num_Pontos.ToString();
         Destroy(col.gameObject);
      }
      else if (col.transform.tag == "Lipidios")
      {
         audios[0].Play();
         Num_Pontos += 8;
         delaySpawnObj.gordao -= 8f;
         Text_Pontos.text = Num_Pontos.ToString();
         Destroy(col.gameObject);
      }
      else if (col.transform.tag == "Proteinas")
      {
         audios[0].Play();
         Num_Pontos += 5;
         delaySpawnObj.gordao -= 5f;
         Text_Pontos.text = Num_Pontos.ToString();
         Destroy(col.gameObject);
      }

      if (col.transform.name == "Start_Info")
      {
         Destroy(col.gameObject);
         Info_Jogo.SetTrigger("Start");
      }
      else if (col.transform.name == "Fim_Info")
      {
         Destroy(col.gameObject);
         Info_Jogo.SetTrigger("Terminou_Info_Jogo");
      }
      else if (col.transform.name == "Start_Info_2")
      {
         Destroy(col.gameObject);
         Info_Pause.SetTrigger("Terminou_Info_Jogo");
      }
      else if (col.transform.name == "Fim_Info_2")
      {
         Destroy(col.gameObject);
         Info_Pause.SetTrigger("Terminou_Info_Pausar");
      }

   }
}

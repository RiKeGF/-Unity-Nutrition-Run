using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{
   public Image barraEnergia;
   public int gordaoCheio = 100;

   public float contagem;
   public float numContagem = 5f;

   public float spawnTimeGorduras = 2.5f;
   public float spawnTimeNutrientes = 2;

   public float gordao = 0;
   private float gordaoCD;
   public float gordaoTempo = 8f;

   bool[] check = new bool[5];

   public GameObject[] Nutrientes;
   //public GameObject[] Inimigos;
   public GameObject[] Gorduras;

   private Pause pause;

   private Player player;

   void Start()
   {

      player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
      pause = GameObject.FindGameObjectWithTag("CanvasPause").GetComponent<Pause>();

      contagem = numContagem;

      gordaoCD = gordaoTempo;

      InvokeRepeating("SpawnNutrientes", spawnTimeNutrientes, spawnTimeNutrientes);
      InvokeRepeating("SpawnGorduras", spawnTimeGorduras, spawnTimeGorduras);
      InvokeRepeating("SpawnGordurasP", 1, 1);

      for (int i = 0; i < 2; i++)
      {
         Vector3 position = new Vector3(Random.Range(-21.0f, 23.0f), Random.Range(10.0f, 35.0f), this.transform.position.z + Random.Range(400, 600));
         Instantiate(Nutrientes[Random.Range(0, 6)], position, Quaternion.identity);

         position = new Vector3(Random.Range(-21.0f, 23.0f), Random.Range(10.0f, 35.0f), this.transform.position.z + Random.Range(500, 1000));
         Instantiate(Nutrientes[Random.Range(0, 6)], position, Quaternion.identity);

         position = new Vector3(Random.Range(-21.0f, 23.0f), Random.Range(10.0f, 35.0f), this.transform.position.z + Random.Range(1200, 1800));
         Instantiate(Nutrientes[Random.Range(0, 6)], position, Quaternion.identity);

         position = new Vector3(Random.Range(-21.0f, 23.0f), Random.Range(10.0f, 35.0f), this.transform.position.z + Random.Range(1000, 2000));
         Instantiate(Nutrientes[Random.Range(0, 6)], position, Quaternion.identity);

         position = new Vector3(Random.Range(-21.0f, 23.0f), Random.Range(10.0f, 35.0f), this.transform.position.z + Random.Range(500, 1500));
         Instantiate(Nutrientes[Random.Range(0, 6)], position, Quaternion.identity);

         position = new Vector3(Random.Range(-21.0f, 23.0f), Random.Range(10.0f, 35.0f), this.transform.position.z + Random.Range(800, 1000));
         Instantiate(Nutrientes[Random.Range(0, 6)], position, Quaternion.identity);

         position = new Vector3(Random.Range(-21.0f, 23.0f), Random.Range(10.0f, 35.0f), this.transform.position.z + Random.Range(1600, 2000));
         Instantiate(Nutrientes[Random.Range(0, 6)], position, Quaternion.identity);

         position = new Vector3(Random.Range(-21.0f, 23.0f), Random.Range(10.0f, 35.0f), this.transform.position.z + Random.Range(1000, 1500));
         Instantiate(Gorduras[0], position, Quaternion.identity);

         position = new Vector3(Random.Range(-21.0f, 23.0f), Random.Range(10.0f, 35.0f), this.transform.position.z + Random.Range(1500, 2000));
         Instantiate(Gorduras[0], position, Quaternion.identity);

         position = new Vector3(Random.Range(-21.0f, 23.0f), Random.Range(10.0f, 35.0f), this.transform.position.z + Random.Range(2000, 2200));
         Instantiate(Gorduras[0], position, Quaternion.identity);

         position = new Vector3(Random.Range(-21.0f, 23.0f), Random.Range(10.0f, 35.0f), this.transform.position.z + Random.Range(2200, 2500));
         Instantiate(Gorduras[1], position, Quaternion.identity);

         position = new Vector3(Random.Range(-21.0f, 23.0f), Random.Range(10.0f, 35.0f), this.transform.position.z + Random.Range(2000, 2500));
         Instantiate(Nutrientes[Random.Range(0, 6)], position, Quaternion.identity);

         position = new Vector3(Random.Range(-21.0f, 23.0f), Random.Range(10.0f, 35.0f), this.transform.position.z + Random.Range(2500, 3000));
         Instantiate(Nutrientes[Random.Range(0, 6)], position, Quaternion.identity);

         position = new Vector3(Random.Range(-21.0f, 23.0f), Random.Range(10.0f, 35.0f), this.transform.position.z + Random.Range(3000, 3500));
         Instantiate(Nutrientes[Random.Range(0, 6)], position, Quaternion.identity);

         position = new Vector3(Random.Range(-21.0f, 23.0f), Random.Range(10.0f, 35.0f), this.transform.position.z + Random.Range(3500, 4000));
         Instantiate(Nutrientes[Random.Range(0, 6)], position, Quaternion.identity);

         for (int j = 0; j < 2; j++)
         {
            position = new Vector3(Random.Range(-21.0f, 23.0f), Random.Range(10.0f, 35.0f), this.transform.position.z + Random.Range(4500, 5000));
            Instantiate(Nutrientes[Random.Range(0, 6)], position, Quaternion.identity);

            position = new Vector3(Random.Range(-21.0f, 23.0f), Random.Range(10.0f, 35.0f), this.transform.position.z + Random.Range(5000, 5500));
            Instantiate(Nutrientes[Random.Range(0, 6)], position, Quaternion.identity);

            position = new Vector3(Random.Range(-21.0f, 23.0f), Random.Range(10.0f, 35.0f), this.transform.position.z + Random.Range(3000, 5000));
            Instantiate(Gorduras[0], position, Quaternion.identity);

            position = new Vector3(Random.Range(-21.0f, 23.0f), Random.Range(10.0f, 35.0f), this.transform.position.z + Random.Range(3000, 5000));
            Instantiate(Gorduras[0], position, Quaternion.identity);
         }
         for (int j = 0; j < 2; j++)
         {
            position = new Vector3(Random.Range(-21.0f, 23.0f), Random.Range(10.0f, 35.0f), this.transform.position.z + Random.Range(5000, 5500));
            Instantiate(Nutrientes[Random.Range(0, 6)], position, Quaternion.identity);

            position = new Vector3(Random.Range(-21.0f, 23.0f), Random.Range(10.0f, 35.0f), this.transform.position.z + Random.Range(5500, 6000));
            Instantiate(Nutrientes[Random.Range(0, 6)], position, Quaternion.identity);

         }

      }

   }


   void Update()
   {

      gordaoFunction();
      barra();

   }


   public void gordaoFunction()
   {


      if (!pause.pause)
      {
         gordaoCD -= 0.5f;

         if (gordaoCD <= 0)
         {
            if (gordao > 80 && gordao <= 100)
            {
               if (!check[4])
               {
                  player.speed = 270;

                  spawnTimeNutrientes = 0.5f;
                  spawnTimeGorduras = 0.1f;

                  player.speedMax = player.speed;

                  player.tempo_distPercorrida = 5f;

                  CancelInvoke("SpawnNutrientes");
                  InvokeRepeating("SpawnNutrientes", spawnTimeNutrientes, spawnTimeNutrientes);

                  CancelInvoke("SpawnGorduras");
                  InvokeRepeating("SpawnGorduras", spawnTimeGorduras, spawnTimeGorduras);

                  check[4] = true;
                  check[3] = false;

               }

            }
            else if (gordao > 60 && gordao <= 80)
            {
               if (!check[3])
               {
                  player.speed = 220;

                  player.speedMax = player.speed;

                  spawnTimeGorduras = 0.5f;

                  player.moveForce = 60;
                  player.moveForceY = 10;

                  player.tempo_distPercorrida = 4f;

                  CancelInvoke("SpawnNutrientes");
                  InvokeRepeating("SpawnNutrientes", spawnTimeNutrientes, spawnTimeNutrientes);

                  CancelInvoke("SpawnGorduras");
                  InvokeRepeating("SpawnGorduras", spawnTimeGorduras, spawnTimeGorduras);

                  check[4] = false;
                  check[3] = true;
                  check[2] = false;

               }

            }
            else if (gordao > 40 && gordao <= 60)
            {
               if (!check[2])
               {
                  player.speed = 180;

                  spawnTimeNutrientes = 1f;
                  spawnTimeGorduras = 1f;

                  player.speedMax = player.speed;

                  player.tempo_distPercorrida = 3f;

                  CancelInvoke("SpawnNutrientes");
                  InvokeRepeating("SpawnNutrientes", spawnTimeNutrientes, spawnTimeNutrientes);

                  CancelInvoke("SpawnGorduras");
                  InvokeRepeating("SpawnGorduras", spawnTimeGorduras, spawnTimeGorduras);

                  check[3] = false;
                  check[2] = true;
                  check[1] = false;

               }

            }
            else if (gordao > 20 && gordao <= 40)
            {
               if (!check[1])
               {
                  player.speed = 150;

                  spawnTimeNutrientes = 1.5f;
                  spawnTimeGorduras = 2f;

                  player.speedMax = player.speed;

                  player.moveForce = 50;
                  player.moveForceY = 10;

                  player.tempo_distPercorrida = 2f;

                  CancelInvoke("SpawnNutrientes");
                  InvokeRepeating("SpawnNutrientes", spawnTimeNutrientes, spawnTimeNutrientes);

                  CancelInvoke("SpawnGorduras");
                  InvokeRepeating("SpawnGorduras", spawnTimeGorduras, spawnTimeGorduras);

                  check[2] = false;
                  check[1] = true;
                  check[0] = false;

               }

            }
            else if (gordao <= 20)
            {
               if (!check[0])
               {
                  player.speed = 150;

                  spawnTimeNutrientes = 1.5f;
                  spawnTimeGorduras = 2f;

                  player.speedMax = player.speed;

                  player.moveForce = 50;
                  player.moveForceY = 10;

                  player.tempo_distPercorrida = 2f;

                  CancelInvoke("SpawnNutrientes");
                  InvokeRepeating("SpawnNutrientes", spawnTimeNutrientes, spawnTimeNutrientes);

                  CancelInvoke("SpawnGorduras");
                  InvokeRepeating("SpawnGorduras", spawnTimeGorduras, spawnTimeGorduras);


                  check[1] = false;
                  check[0] = true;

               }


            }


            gordao++;

            gordaoCD = gordaoTempo;
         }

         if (gordao <= 0)
         {
            gordao = 0;
         }
         else if (gordao >= 100)
         {
            gordao = 100;
         }
      }

   }

   public void SpawnNutrientes()
   {

      Vector3 position;

      //Nutrientes

      int objectIndex = Random.Range(0, 6);
      int guardarValor = objectIndex;

      while (guardarValor == objectIndex)
      {
         objectIndex = Random.Range(0, 6);
      }

      position = new Vector3(Random.Range(-21.0f, 23.0f), Random.Range(10.0f, 35.0f), this.transform.position.z + Random.Range(2500, 2700));

      Instantiate(Nutrientes[objectIndex], position, Quaternion.identity);

   }

   public void SpawnGorduras()
   {

      Vector3 position;

      //Nutrientes

      int objectIndex = Random.Range(0, 6);

      position = new Vector3(Random.Range(-21.0f, 23.0f), Random.Range(10.0f, 35.0f), this.transform.position.z + Random.Range(2500, 2700));

      Instantiate(Nutrientes[objectIndex], position, Quaternion.identity);

      //Gorduras
      if (gordao > 50)
      {
         objectIndex = Random.Range(0, 3);

         if (objectIndex == 2)
         {
            int random = Random.Range(0, 4);

            switch (random)
            {
               case 0:
               {
                  position = new Vector3(Random.Range(-21.0f, 0), Random.Range(0, 20.0f), this.transform.position.z + Random.Range(2500, 2700));

                  Instantiate(Gorduras[objectIndex], position, Quaternion.identity);

                  break;
               }
               case 1:
               {
                  position = new Vector3(Random.Range(-21.0f, 0), Random.Range(20.0f, 35.0f), this.transform.position.z + Random.Range(2500, 2700));

                  Instantiate(Gorduras[objectIndex], position, Quaternion.identity);

                  break;
               }
               case 2:
               {
                  position = new Vector3(Random.Range(0, 23.0f), Random.Range(0, 20.0f), this.transform.position.z + Random.Range(2500, 2700));

                  Instantiate(Gorduras[objectIndex], position, Quaternion.identity);

                  break;
               }
               case 3:
               {
                  position = new Vector3(Random.Range(0, 23.0f), Random.Range(20.0f, 35.0f), this.transform.position.z + Random.Range(2500, 2700));

                  Instantiate(Gorduras[objectIndex], position, Quaternion.identity);

                  break;
               }
            }
         }
         else
         {
            position = new Vector3(Random.Range(-21.0f, 23.0f), Random.Range(10.0f, 35.0f), this.transform.position.z + Random.Range(2500, 2700));

            Instantiate(Gorduras[objectIndex], position, Quaternion.identity);
         }

      }
      else if (gordao > 20 && gordao <= 50)
      {
         objectIndex = Random.Range(0, 2);

         position = new Vector3(Random.Range(-21.0f, 23.0f), Random.Range(10.0f, 35.0f), this.transform.position.z + Random.Range(2500, 2700));

         Instantiate(Gorduras[objectIndex], position, Quaternion.identity);
      }
   }

   public void SpawnGordurasP()
   {

      Vector3 position;

      //Gorduras

      int objectIndex = 0;

      position = new Vector3(Random.Range(-21.0f, 23.0f), Random.Range(10.0f, 35.0f), this.transform.position.z + Random.Range(2500, 2700));

      Instantiate(Gorduras[objectIndex], position, Quaternion.identity);

   }

   private void barra()
   {
      if (!player.morreu)
      {
         barraEnergia.transform.localScale = new Vector3(1, -gordao / gordaoCheio, 1);

      }

   }

   private void OnTriggerEnter(Collider col)
   {
      if (col.transform.tag == "Check")
      {
         if (gordaoTempo > 4)
         {
            gordaoTempo -= 2f;
         }
         else if (gordaoTempo > 2 &&  gordaoTempo <= 4)
         {
            gordaoTempo -= 1f;
         }
      }
   }
}
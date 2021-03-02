using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigos : MonoBehaviour
{

   private string direção = "D";

   private int nivel = 0;

   private Player player;

   Vector3 position;

   public int padrao;


   void Start()
   {
      nivel = 1;
      player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
      padrao = Random.Range(1, 7);


      setPositionInimigos();
      this.transform.position = position;
   }


   void setPositionInimigos()
   {
      if (padrao == 1)
      {
         position = new Vector3(18, 35, player.transform.position.z + 2500.0f);
      }
      else if (padrao == 2)
      {
         position = new Vector3(18, 8, player.transform.position.z + 2500.0f);
      }
      else if (padrao == 3)
      {
         position = new Vector3(-18, 35, player.transform.position.z + 2500.0f);
      }
      else if (padrao == 4)
      {
         position = new Vector3(18, 35, player.transform.position.z + 2500.0f);
      }
      else if (padrao == 5)
      {
         position = new Vector3(-18, 8, player.transform.position.z + 2500.0f);
      }
      else
      {
         position = new Vector3(0.5f, 20, player.transform.position.z + 2500.0f);
      }
   }

   void FixedUpdate()
   {
      if (padrao == 1)
      {
         if (this.transform.position.x >= 18 && this.transform.position.y >= 35 && nivel == 1)
         {
            nivel = 2;
            direção = "E";
         }
         else if (this.transform.position.x <= -18 && this.transform.position.y >= 34 && nivel == 2)
         {
            nivel = 3;
            direção = "B";
         }
         else if (this.transform.position.x <= -18 && this.transform.position.y <= 20 && nivel == 3)
         {
            nivel = 4;
            direção = "D";
         }
         else if (this.transform.position.x >= 18 && this.transform.position.y <= 20 && nivel == 4)
         {
            nivel = 5;
            direção = "B";
         }
         if (this.transform.position.x >= 18 && this.transform.position.y <= 8 && nivel == 5)
         {
            nivel = 6;
            direção = "E";
         }
         else if (this.transform.position.x <= -18 && this.transform.position.y <= 8 && nivel == 6)
         {
            nivel = 1;
            direção = "DD";
         }

         //-----------------------------------------------------------------------------------------

         if (direção == "D")
         {
            this.transform.Translate((20 * Time.deltaTime), 0, 0);
         }
         else if (direção == "E")
         {
            this.transform.Translate((-20 * Time.deltaTime), 0, 0);
         }
         else if (direção == "B")
         {
            this.transform.Translate(0, (-15 * Time.deltaTime), 0);
         }
         else if (direção == "DD")
         {
            this.transform.Translate((20 * Time.deltaTime), (15 * Time.deltaTime), 0);
         }
      }
      else if (padrao == 2)
      {
         if (this.transform.position.x >= 18 && this.transform.position.y <= 8 && nivel == 1)
         {
            nivel = 2;
            direção = "C";
         }
         else if (this.transform.position.x >= 18 && this.transform.position.y >= 34 && nivel == 2)
         {
            nivel = 3;
            direção = "DBE";
         }
         else if (this.transform.position.x <= 0.5f && this.transform.position.y <= 10 && nivel == 3)
         {
            nivel = 4;
            direção = "C";
         }
         else if (this.transform.position.x <= 0.5f && this.transform.position.y >= 35 && nivel == 4)
         {
            nivel = 5;
            direção = "DBE";
         }
         else if (this.transform.position.x <= -18 && this.transform.position.y <= 8 && nivel == 5)
         {
            nivel = 6;
            direção = "C";
         }
         else if (this.transform.position.x <= -18 && this.transform.position.y >= 34 && nivel == 6)
         {
            nivel = 1;
            direção = "DBD";
         }

         //-----------------------------------------------------------------------------------------

         if (direção == "DBD")
         {
            this.transform.Translate((20 * Time.deltaTime), (-15 * Time.deltaTime), 0);
         }
         else if (direção == "DBE")
         {
            this.transform.Translate((-10 * Time.deltaTime), (-15 * Time.deltaTime), 0);
         }
         else if (direção == "C")
         {
            this.transform.Translate(0, (15 * Time.deltaTime), 0);
         }
      }
      else if (padrao == 3)
      {
         if (this.transform.position.x <= -18 && this.transform.position.y >= 34 && nivel == 1)
         {
            nivel = 2;
            direção = "D";
         }
         else if (this.transform.position.x >= 18 && this.transform.position.y >= 34 && nivel == 2)
         {
            nivel = 3;
            direção = "DBE";
         }
         else if (this.transform.position.x <= -18 && this.transform.position.y >= 15 && nivel == 3)
         {
            nivel = 4;
            direção = "DBD";
         }
         else if (this.transform.position.x >= 18 && this.transform.position.y >= 8 && nivel == 4)
         {
            nivel = 5;
            direção = "DBE";
         }
         else if (this.transform.position.x >= -18 && this.transform.position.y <= 8 && nivel == 5)
         {
            nivel = 6;
            direção = "D";
         }
         else if (this.transform.position.x >= 18 && this.transform.position.y <= 8 && nivel == 6)
         {
            nivel = 1;
            direção = "DCE";
         }


         //-----------------------------------------------------------------------------------------

         if (direção == "D")
         {
            this.transform.Translate((20 * Time.deltaTime), 0, 0);
         }
         else if (direção == "E")
         {
            this.transform.Translate((-20 * Time.deltaTime), 0, 0);
         }
         else if (direção == "DBD")
         {
            this.transform.Translate((20 * Time.deltaTime), (-5 * Time.deltaTime), 0);
         }
         else if (direção == "DBE")
         {
            this.transform.Translate((-20 * Time.deltaTime), (-5 * Time.deltaTime), 0);
         }
         else if (direção == "DCE")
         {
            this.transform.Translate((-20 * Time.deltaTime), (15 * Time.deltaTime), 0);
         }
      }
      else if (padrao == 4)
      {
         if (this.transform.position.x >= 18 && this.transform.position.y >= 34 && nivel == 1)
         {
            nivel = 2;
            direção = "DBE";
         }
         else if (this.transform.position.x <= -18 && this.transform.position.y <= 8 && nivel == 2)
         {
            nivel = 3;
            direção = "DCD";
         }
         else if (this.transform.position.x >= 0.5f && this.transform.position.y >= 34 && nivel == 3)
         {
            nivel = 4;
            direção = "B";
         }
         else if (this.transform.position.x >= 0.5f && this.transform.position.y <= 8 && nivel == 4)
         {
            nivel = 5;
            direção = "DCE";
         }
         else if (this.transform.position.x <= -18 && this.transform.position.y >= 34 && nivel == 5)
         {
            nivel = 6;
            direção = "DBD";
         }
         else if (this.transform.position.x >= 18 && this.transform.position.y <= 8 && nivel == 6)
         {
            nivel = 1;
            direção = "C";
         }


         //-----------------------------------------------------------------------------------------

         if (direção == "DCD")
         {
            this.transform.Translate((15 * Time.deltaTime), (15 * Time.deltaTime), 0);
         }
         else if (direção == "B")
         {
            this.transform.Translate(0, (-15 * Time.deltaTime), 0);
         }
         else if (direção == "C")
         {
            this.transform.Translate(0, (15 * Time.deltaTime), 0);
         }
         else if (direção == "DBD")
         {
            this.transform.Translate((20 * Time.deltaTime), (-15 * Time.deltaTime), 0);
         }
         else if (direção == "DBE")
         {
            this.transform.Translate((-20 * Time.deltaTime), (-15 * Time.deltaTime), 0);
         }
         else if (direção == "DCE")
         {
            this.transform.Translate((-20 * Time.deltaTime), (15 * Time.deltaTime), 0);
         }
      }
      else if (padrao == 5)
      {
         if (this.transform.position.x >= -18 && this.transform.position.y >= 8 && nivel == 1)
         {
            nivel = 2;
            direção = "DCD";
         }
         else if (this.transform.position.x >= 18 && this.transform.position.y >= 34 && nivel == 2)
         {
            nivel = 3;
            direção = "DBE1";
         }
         else if (this.transform.position.x <= -18 && this.transform.position.y >= 15 && nivel == 3)
         {
            nivel = 4;
            direção = "DBD1";
         }
         else if (this.transform.position.x >= 0.5f && this.transform.position.y <= 8 && nivel == 4)
         {
            nivel = 5;
            direção = "D";
         }
         else if (this.transform.position.x >= 18 && this.transform.position.y <= 8 && nivel == 5)
         {
            nivel = 6;
            direção = "DCE";
         }
         else if (this.transform.position.x <= 0.5f && this.transform.position.y >= 34 && nivel == 6)
         {
            nivel = 7;
            direção = "E";
         }
         else if (this.transform.position.x <= -18 && this.transform.position.y >= 34 && nivel == 7)
         {
            nivel = 8;
            direção = "DBD2";
         }
         else if (this.transform.position.x >= 18 && this.transform.position.y <= 20 && nivel == 8)
         {
            direção = "DBE2";
         }
         else if (this.transform.position.x <= -18 && this.transform.position.y <= 8 && nivel == 8)
         {
            nivel = 2;
            direção = "DCD";
         }

         //-----------------------------------------------------------------------------------------

         if (direção == "DCD")
         {
            this.transform.Translate((20 * Time.deltaTime), (15 * Time.deltaTime), 0);
         }
         else if (direção == "DBD1")
         {
            this.transform.Translate((20 * Time.deltaTime), (-10 * Time.deltaTime), 0);
         }
         else if (direção == "DBD2")
         {
            this.transform.Translate((20 * Time.deltaTime), (-7 * Time.deltaTime), 0);
         }
         else if (direção == "DBE1")
         {
            this.transform.Translate((-25 * Time.deltaTime), (-10 * Time.deltaTime), 0);
         }
         else if (direção == "DBE2")
         {
            this.transform.Translate((-20 * Time.deltaTime), (-10 * Time.deltaTime), 0);
         }
         else if (direção == "DCE")
         {
            this.transform.Translate((-15 * Time.deltaTime), (20 * Time.deltaTime), 0);
         }
         else if (direção == "D")
         {
            this.transform.Translate((20 * Time.deltaTime), 0, 0);
         }
         else if (direção == "E")
         {
            this.transform.Translate((-20 * Time.deltaTime), 0, 0);
         }
      }
      else
      {

         if (this.transform.position.x >= 0.5f && this.transform.position.y >= 20 && nivel == 1)
         {
            nivel = 2;
            direção = "DCD";
         }
         else if (this.transform.position.x >= 18 && this.transform.position.y >= 34 && nivel == 2)
         {
            nivel = 3;
            direção = "B";
         }
         else if (this.transform.position.x >= 18 && this.transform.position.y <= 8 && nivel == 3)
         {
            nivel = 4;
            direção = "DCE1";
         }
         else if (this.transform.position.x <= 0.5f && this.transform.position.y >= 34 && nivel == 4)
         {
            nivel = 5;
            direção = "DBE";
         }
         else if (this.transform.position.x <= -18 && this.transform.position.y <= 8 && nivel == 5)
         {
            nivel = 6;
            direção = "D";
         }
         else if (this.transform.position.x >= 18 && this.transform.position.y <= 8 && nivel == 6)
         {
            nivel = 7;
            direção = "DCE2";
         }
         else if (this.transform.position.x <= -18 && this.transform.position.y >= 15 && nivel == 7)
         {
            nivel = 8;
            direção = "C";
         }
         else if (this.transform.position.x <= -18 && this.transform.position.y >= 34 && nivel == 8)
         {
            nivel = 1;
            direção = "DBD";
         }


         //-----------------------------------------------------------------------------------------

         if (direção == "DCD")
         {
            this.transform.Translate((20 * Time.deltaTime), (15 * Time.deltaTime), 0);
         }
         else if (direção == "DBD")
         {
            this.transform.Translate((20 * Time.deltaTime), (-10 * Time.deltaTime), 0);
         }
         else if (direção == "DBE")
         {
            this.transform.Translate((-15 * Time.deltaTime), (-15 * Time.deltaTime), 0);
         }
         else if (direção == "DCE1")
         {
            this.transform.Translate((-10 * Time.deltaTime), (15 * Time.deltaTime), 0);
         }
         else if (direção == "DCE2")
         {
            this.transform.Translate((-15 * Time.deltaTime), (5 * Time.deltaTime), 0);
         }
         else if (direção == "D")
         {
            this.transform.Translate((20 * Time.deltaTime), 0, 0);
         }
         else if (direção == "B")
         {
            this.transform.Translate(0, (-15 * Time.deltaTime), 0);
         }
         else if (direção == "C")
         {
            this.transform.Translate(0, (15 * Time.deltaTime), 0);
         }
      }
   }
}

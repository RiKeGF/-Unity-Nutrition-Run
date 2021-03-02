using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{

   public GameObject camera;
   public GameObject[] Points;

   public bool creditos;
   public bool menuEsq;
   public bool menuCima;
   public bool instrucoesCima;
   public bool instrucoesBaixo;
   public bool instrucoesEsq;
   public bool instrucoesDir;
   public bool sobre;
   public bool interfac;
   public bool conteudo;
   public AudioSource[] audio = new AudioSource[2];


   // Use this for initialization
   void Start()
   {
      Time.timeScale = 1;
      camera.transform.position = new Vector3(150, 150, -400);
   }



   private void Update()
   {
   }

   private void FixedUpdate()
   {
      //Creditos
      if (creditos == true)
      {
         if (camera.transform.position.x <= 900)
         {
            camera.transform.Translate((1000 * Time.deltaTime), 0, 0);
         }
         else
         {
            creditos = false;
         }
      }


      //MenuEsq
      if (menuEsq == true)
      {
         if (camera.transform.position.x >= 150)
         {
            camera.transform.Translate((-1000 * Time.deltaTime), 0, 0);
         }
         else
         {
            menuEsq = false;
         }
      }


      //MenuCima
      if (menuCima == true)
      {
         if (camera.transform.position.y < 150)
         {
            camera.transform.Translate(0, (600 * Time.deltaTime), 0);
         }
         else
         {
            menuCima = false;
         }
      }


      //InstruçõesBaixo
      if (instrucoesBaixo == true)
      {
         if (camera.transform.position.y >= -400)
         {
            camera.transform.Translate(0, (-600 * Time.deltaTime), 0);
         }
         else
         {
            instrucoesBaixo = false;
         }
      }

      //InstruçõesCima
      if (instrucoesCima == true)
      {
         if (camera.transform.position.y <= -400)
         {
            camera.transform.Translate(0, (600 * Time.deltaTime), 0);
         }
         else
         {
            instrucoesCima = false;
         }
      }

      //InstruçõesEsq
      if (instrucoesEsq == true)
      {
         if (camera.transform.position.x >= 150)
         {
            camera.transform.Translate((-800 * Time.deltaTime), 0, 0);
         }
         else
         {
            instrucoesEsq = false;
         }
      }

      //InstruçõesDir
      if (instrucoesDir == true)
      {
         if (camera.transform.position.x <= 150)
         {
            camera.transform.Translate((800 * Time.deltaTime), 0, 0);
         }
         else
         {
            instrucoesDir = false;
         }
      }

      //Sobre
      if (sobre == true)
      {
         if (camera.transform.position.x <= 820)
         {
            camera.transform.Translate((800 * Time.deltaTime), 0, 0);
         }
         else
         {
            sobre = false;
         }
      }

      //Interface
      if (interfac == true)
      {
         if (camera.transform.position.x >= -670)
         {
            camera.transform.Translate((-800 * Time.deltaTime), 0, 0);
         }
         else
         {
            interfac = false;
         }
      }

      //Conteudo
      if (conteudo == true)
      {
         if (camera.transform.position.y >= -936)
         {
            camera.transform.Translate(0, (-600 * Time.deltaTime), 0);
         }
         else
         {
            conteudo = false;
         }
      }

   }

   public void Creditos()
   {
      audio[0].Play();
      audio[1].Play();
      creditos = true;
   }

   public void MenuEsq()
   {
      audio[0].Play();
      audio[1].Play();
      menuEsq = true;
   }
   public void MenuCima()
   {
      audio[0].Play();
      audio[1].Play();
      menuCima = true;
   }

   public void InstruçõesBaixo()
   {
      audio[0].Play();
      audio[1].Play();
      instrucoesBaixo = true;
   }
   public void InstruçõesCima()
   {
      audio[0].Play();
      audio[1].Play();
      instrucoesCima = true;
   }
   public void InstruçõesDir()
   {
      audio[0].Play();
      audio[1].Play();
      instrucoesDir = true;
   }
   public void InstruçõesEsq()
   {
      audio[0].Play();
      audio[1].Play();
      instrucoesEsq = true;
   }

   public void Sobre()
   {
      audio[0].Play();
      audio[1].Play();
      sobre = true;
   }

   public void Conteudo()
   {
      audio[0].Play();
      audio[1].Play();
      conteudo = true;
   }

   public void Interfac()
   {
      audio[0].Play();
      audio[1].Play();
      interfac = true;
   }


   public void iniciarJogo()
   {
      SceneManager.LoadScene("Infinity Run");
   }

   public void fecharJogo()
   {
      Application.Quit();
   }

}

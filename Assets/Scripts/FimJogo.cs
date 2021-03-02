using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FimJogo : MonoBehaviour {


    public void Recomeçar()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Infinity Run");
    }

    public void LoadMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }

    public void Sair()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonSalirYEntrarNivel : MonoBehaviour
{
    public string nivelLoad = "MainLevel";

    public void Play()
    {
        SceneManager.LoadScene(nivelLoad);
    }

    public void Quit()
    {
        Debug.Log("Salida");
        Application.Quit();
    }
}

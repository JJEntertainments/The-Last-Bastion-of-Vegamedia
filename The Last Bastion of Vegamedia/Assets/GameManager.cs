using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    private bool JuegoFz = false;

    public int vidaT;


    public GameObject gameOverUI;


    // Update is called once per frame
    void Update()
    {
        if (JuegoFz)
            return;

        if (vidaT == 0)
        {
            FinalizarJuego();
        }
        
    }

    void FinalizarJuego()
    {
        JuegoFz=true;

        gameOverUI.SetActive(true);
    }
}

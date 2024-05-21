using UnityEditor;
using UnityEngine;
using System.Collections;

public class vidacastillo : MonoBehaviour
{
    public int maxHealth = 10;
    public static int currentHealth;



    public static bool JuegoFz = false;
    public static bool JuegoPau = false;

    public GameObject gameOverUI;
    public GameObject gameWinUI;
    public GameObject gamePauseUI;

    void Start()
    {
        JuegoFz = false;
        JuegoPau = false;
        gameWinUI.SetActive(false);
        gameOverUI.SetActive(false);
        gamePauseUI.SetActive(false);
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("Vida del castillo: " + currentHealth);




        if (currentHealth <= 0)
        {
            Debug.Log("¡El castillo ha sido destruido! Fin del juego.");
            FinalizarJuego(); 

        }


        if (WaveSpawner.totalEnemies == Goblin1.goblinosMuertos)
            FinalizarJuegoWin();
    }
    void Update()
    {
        if (JuegoFz)
            return;


        if (Input.GetKeyDown("e"))
            FinalizarJuego();

        if(Input.GetKeyDown("x"))
            FinalizarJuegoWin();

        if (Input.GetKeyDown(KeyCode.Escape))
            if (JuegoPau)
                DespausarJuego();
            else
                PausarJuego();
        

        if (WaveSpawner.totalEnemies == Goblin1.goblinosMuertos )
            FinalizarJuegoWin();



    }

    void DespausarJuego()
    {
        JuegoPau = false;
        gamePauseUI.SetActive(false);
    }
    void PausarJuego()
    {
        JuegoPau = true;
        gamePauseUI.SetActive(true);
    }
    void FinalizarJuegoWin()
    {
        JuegoFz = true;

        gameWinUI.SetActive(true);
    }
    void FinalizarJuego()
    {
        JuegoFz = true;

        gameOverUI.SetActive(true);
    }

   
}
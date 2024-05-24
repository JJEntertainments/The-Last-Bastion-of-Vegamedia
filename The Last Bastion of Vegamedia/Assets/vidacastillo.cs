using UnityEditor;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class vidacastillo : MonoBehaviour
{
    public int maxHealth = 10;
    public static int currentHealth ;



    public static bool JuegoFz = false;
    public static bool JuegoPau = false;

    public Slider slider;
    public GameObject gameOverUI;
    public GameObject gameWinUI;
    public GameObject gamePauseUI;
    public GameObject gameVidaMonedasUI;

    void Start()
    {
        currentHealth = maxHealth;
        SetMaxHealth();
        
        JuegoFz = false;
        JuegoPau = false;
        gameWinUI.SetActive(false);
        gameOverUI.SetActive(false);
        gamePauseUI.SetActive(false);
        gameVidaMonedasUI.SetActive(true);

    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("Vida del castillo: " + currentHealth);



        SetHealth();
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
        gameVidaMonedasUI.SetActive(true);
    }
    void PausarJuego()
    {
        JuegoPau = true;
        gamePauseUI.SetActive(true);
        gameVidaMonedasUI.SetActive(false);
    }
    void FinalizarJuegoWin()
    {
        JuegoFz = true;
        gameWinUI.SetActive(true);
        gameVidaMonedasUI.SetActive(false);

    }
    void FinalizarJuego()
    {
        JuegoFz = true;

        gameOverUI.SetActive(true);
        gameVidaMonedasUI.SetActive(false);
    }

    public void SetHealth()
    {
        slider.value = currentHealth;
    }
    public void SetMaxHealth()
    {
        slider.maxValue = currentHealth;
        slider.value = currentHealth;
    }

}
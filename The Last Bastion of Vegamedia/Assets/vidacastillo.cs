using UnityEngine;

public class vidacastillo : MonoBehaviour
{
    public int maxHealth = 10;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("Vida del castillo: " + currentHealth);

        if (currentHealth <= 0)
        {
            Debug.Log("�El castillo ha sido destruido! Fin del juego.");
            // Aqu� puedes a�adir cualquier l�gica adicional para el final del juego
        }
    }
}
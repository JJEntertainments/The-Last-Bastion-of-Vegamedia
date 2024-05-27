using System;
using UnityEngine;

public class Goblin1 : MonoBehaviour
{
    public float speed = 5f;
    public int vida = 2;

    private Transform target;
    private int wavepointIndex = 0;
    public static int goblinosMuertos = 0;
    public int damageToCastillo = 1; // Daño que se realiza al castillo

    void Start()
    {
        
        target = WayPoints.Waypoints[0];
    }

    private void Update()
    {
        if (!vidacastillo.JuegoFz && !vidacastillo.JuegoPau)
        {
            if (vida <= 0) // Si la salud llega a 0 o menos, destruye el Goblin
            {
                goblinosMuertos++;
                Monedos.AddMonedas(5);
                Debug.Log(goblinosMuertos);

                Destroy(gameObject);
                return;
            }

            Vector3 dir = target.position - transform.position;
            transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);


            if (Vector3.Distance(transform.position, target.position) <= 0.4f)
            {
                GetNextWaypoint();
            }
        }
    }

    private void GetNextWaypoint()
    {
        if (wavepointIndex >= WayPoints.Waypoints.Length - 1)
        {
            // Nuevo: Cuando llega al castillo, le inflige daño
            vidacastillo castle = FindObjectOfType<vidacastillo>();
            if (castle != null)
            {
                castle.TakeDamage(damageToCastillo);
            }
            goblinosMuertos++;
            Destroy(gameObject);
            return;
        }
        wavepointIndex++;
        target = WayPoints.Waypoints[wavepointIndex];
    }

    public void TakeDamage(int damage) // Método para reducir la salud del Goblin cuando recibe daño
    {
        vida -= damage;
    }
}

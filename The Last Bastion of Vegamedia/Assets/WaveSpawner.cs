using UnityEngine;
using System.Collections;

public class WaveSpawner : MonoBehaviour
{
    public Transform PrefabEnemigos;
    public Transform spawnPoint;
    public float timeBetweenWaves = 5f;
    private float countdown = 2f;
    public static int totalEnemies = 40;
    private int enemiesSpawned = 0;
    private int currentWave = 0;

    private void Start()
    {
        Goblin1.goblinosMuertos = 0;
        enemiesSpawned = 0;
        currentWave = 0;
    }

    void Update()
    {
        if (countdown <= 0f && enemiesSpawned < totalEnemies && (!vidacastillo.JuegoFz || !vidacastillo.JuegoPau))
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }

        countdown -= Time.deltaTime;
    }

    IEnumerator SpawnWave()
    {
        currentWave++;
        int enemiesInThisWave;

        if (currentWave <= 3) // Generar goblins en orden ascendente para las primeras 3 oleadas
        {
            enemiesInThisWave = currentWave;
        }
        else
        {
            enemiesInThisWave = Random.Range(1, 6); // Generar goblins aleatoriamente de 1 a 5 a partir de la cuarta oleada
        }

        if (enemiesSpawned + enemiesInThisWave > totalEnemies)
        {
            enemiesInThisWave = totalEnemies - enemiesSpawned;
        }

        for (int i = 0; i < enemiesInThisWave; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }

        enemiesSpawned += enemiesInThisWave;
        Debug.Log(enemiesSpawned + "Spawned");
    }

    void SpawnEnemy()
    {
        Instantiate(PrefabEnemigos, spawnPoint.position, spawnPoint.rotation);
    }
}

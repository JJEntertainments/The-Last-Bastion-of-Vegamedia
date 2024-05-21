using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class WaveSpawner : MonoBehaviour
{
    public Transform PrefabEnemigos;

    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;
    private float countdown = 2f;
    public static int totalEnemies = 10;
    private int enemiesSpawned = 0;

    private void Start()
    {
        Goblin1.goblinosMuertos = 0;
        enemiesSpawned = 0;
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
        int enemiesInThisWave = Random.Range(1, 6);

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
        Debug.Log(enemiesSpawned + "Spanw");
    }

    void SpawnEnemy()
    {
        Instantiate(PrefabEnemigos, spawnPoint.position, spawnPoint.rotation);
    }
}

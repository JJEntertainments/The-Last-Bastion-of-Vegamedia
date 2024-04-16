using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public Transform PrefabEnemigos;

    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;
    private float countdown = 2f;

    private int waveNumber = 1;

    void Update()
    {
        if (countdown <= 0f)
        {
            SpawnWave();
            countdown = timeBetweenWaves;
        }

        countdown -= Time.deltaTime;
    }

    void SpawnWave()
    {
        for (int i = 0; i < waveNumber; i++)
        {
            SpawnEnemy();
        }
        waveNumber++;
    }

    void SpawnEnemy()
    {
        Instantiate(PrefabEnemigos, spawnPoint.position, spawnPoint.rotation);
    }
}

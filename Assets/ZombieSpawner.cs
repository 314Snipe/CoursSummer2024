using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ZombieSpawner : MonoBehaviour
{
    public GameObject zombiePrefab; // Префаб зомби
    public float spawnInterval = 2f; // Интервал между появлениями зомби
    public Vector3 spawnAreaSize = new Vector3(20f, 0f, 20f); // Размер области спавна
    private float nextSpawnTime; // Время следующего спавна

    void Start()
    {
        nextSpawnTime = Time.time + spawnInterval;
    }

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnZombie();
            nextSpawnTime = Time.time + spawnInterval;
        }
    }

    void SpawnZombie()
    {
        // Генерация случайной позиции в пределах области спавна
        Vector3 spawnPosition = transform.position + new Vector3(
            Random.Range(-spawnAreaSize.x / 2f, spawnAreaSize.x / 2f),
            0f,
            Random.Range(-spawnAreaSize.z / 2f, spawnAreaSize.z / 2f)
        );

        // Создание зомби
        Instantiate(zombiePrefab, spawnPosition, Quaternion.identity);
    }
}
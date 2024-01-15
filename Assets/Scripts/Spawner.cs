using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Spawner : MonoBehaviour
{
    public GameObject spawnAsteroid;
    public float initialSpawnRate = 0.1f;
    public float spawnRateIncrease = 0.1f;
    public float maxSpawnRate = 2f;

    private float _currentSpawnRate;

    // Start is called before the first frame update
    void Start()
    {
        _currentSpawnRate = initialSpawnRate;
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        while (_currentSpawnRate > maxSpawnRate)
        {
            float randomX = Random.Range(-8f, 8f);
            Vector3 spawnPosition = new Vector3(randomX, 6f, 0);

            Instantiate(spawnAsteroid, spawnPosition, Quaternion.identity);

            yield return new WaitForSeconds(_currentSpawnRate);
            _currentSpawnRate -= spawnRateIncrease * Time.deltaTime;
        }
    }
}
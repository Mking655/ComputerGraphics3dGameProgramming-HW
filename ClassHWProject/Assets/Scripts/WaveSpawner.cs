using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float startTime;
    public float endTime;
    public float spawnRate;
    public float destroyDelay;

    void Start()
    {
        WavesManager.instance.AddWave(this);
        InvokeRepeating("Spawn", startTime, spawnRate);
        Invoke("CancelInvoke", endTime);
        Destroy(gameObject, destroyDelay);
    }

    void Spawn()
    {
        Instantiate(enemyPrefab, transform.position, transform.rotation);
    }
    private void OnDestroy()
    {
        CancelInvoke();
        WavesManager.instance.RemoveWave(this);
    }
}

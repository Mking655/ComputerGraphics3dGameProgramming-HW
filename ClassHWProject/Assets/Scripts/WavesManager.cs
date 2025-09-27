using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WavesManager : MonoBehaviour
{
    public static WavesManager instance;
    
    public List<WaveSpawner> Waves;
    public UnityEvent OnChanged;

    public void AddWave(WaveSpawner wave) {  Waves.Add(wave); OnChanged.Invoke(); }
    public void RemoveWave(WaveSpawner wave) {  Waves.Remove(wave); OnChanged.Invoke(); }

    private void Awake()
    {
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Debug.LogError("Duplicated Waves, ignoring this instance.", gameObject);
            }
        }
    }
}

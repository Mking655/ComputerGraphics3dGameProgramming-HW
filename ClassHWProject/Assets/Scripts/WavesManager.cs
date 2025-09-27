using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WavesManager : MonoBehaviour
{
    public static WavesManager instance;

    public List<WaveSpawner> Waves;

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WavesGameMode : MonoBehaviour
{
    [SerializeField] private Life playerLife;
    private void Start()
    {
        playerLife.onDeath.AddListener(OnPlayerDied);
        EnemiesManager.instance.OnChanged.AddListener(CheckWinContition);
        WavesManager.instance.OnChanged.AddListener(CheckWinContition);
    }
    void CheckWinContition()
    {
        if (EnemiesManager.instance.enemies.Count <= 0 && WavesManager.instance.Waves.Count <= 0)
        {
            SceneManager.LoadScene("WinScreen");
        }
    }
    private void OnPlayerDied()
    {
        SceneManager.LoadScene("LoseScreen");
    }

}

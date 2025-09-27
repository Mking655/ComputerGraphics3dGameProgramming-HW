using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemiesManager : MonoBehaviour
{
    public static EnemiesManager instance;

    public List<Enemy> enemies;
    public UnityEvent OnChanged;

    public void AddEnemy(Enemy enemy)
    {
        enemies.Add(enemy);
        OnChanged.Invoke();
    }

    public void RemoveEnemy(Enemy enemy)
    {
        enemies.Remove(enemy);
        OnChanged.Invoke();
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogError("Duplicated EnemiesManager, ignoring this instance.", gameObject);
        }
    }
    public void OnDestroy()
    {

    }
}

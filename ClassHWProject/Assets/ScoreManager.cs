using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int ammount;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogError("Duplicated score manager, ignoring this instance.", gameObject);
        }
    }
    public void OnDestroy()
    {
        
    }
}

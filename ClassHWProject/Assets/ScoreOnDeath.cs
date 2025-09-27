using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreOnDeath : MonoBehaviour
{
    public int ammount;
    private Life life;
    private void Awake()
    {
        life = GetComponent<Life>();
        life.onDeath.AddListener(GivePoints);
    }

    void GivePoints()
    {
        ScoreManager.instance.ammount += ammount;
    }

    private void OnDestroy()
    {
        life.onDeath.RemoveListener(GivePoints);
    }
}

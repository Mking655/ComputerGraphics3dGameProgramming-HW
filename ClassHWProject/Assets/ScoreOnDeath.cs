using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreOnDeath : MonoBehaviour
{
    public int ammount;

    private void OnDestroy()
    {
        ScoreManager.instance.ammount += ammount;
    }
}

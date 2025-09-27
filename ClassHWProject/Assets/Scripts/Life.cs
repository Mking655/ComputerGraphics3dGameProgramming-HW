using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Life : MonoBehaviour
{
    public float ammount;
    public UnityEvent onDeath;
    private void Update()
    {
        if (ammount <= 0)
        {
            onDeath.Invoke();
            Destroy(gameObject);
        }
    }
}

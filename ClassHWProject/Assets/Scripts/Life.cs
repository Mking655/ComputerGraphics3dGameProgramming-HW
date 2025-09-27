using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public float ammount;
    private void Update()
    {
        if (ammount <= 0)
        {
            Destroy(gameObject);
        }
    }
}

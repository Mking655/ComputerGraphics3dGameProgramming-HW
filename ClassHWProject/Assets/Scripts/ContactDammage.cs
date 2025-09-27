using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactDammage : MonoBehaviour
{
    public float dammage;
    private void OnTriggerEnter(Collider other)
    {
        Life life = other.GetComponent<Life>();

        if(life != null)
        {
            life.ammount -= dammage;
        }
        Destroy(gameObject);
    }
}

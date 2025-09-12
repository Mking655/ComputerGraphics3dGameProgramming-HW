using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab;
    [SerializeField]
    private Transform shootPoint;

    public void OnFire()
    {
        Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);
    }
}

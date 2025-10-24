using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab;
    [SerializeField]
    private Transform shootPoint;
    public ParticleSystem muzzleEffect;

    public void OnFire()
    {
        Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);
        muzzleEffect.Play();
    }
}

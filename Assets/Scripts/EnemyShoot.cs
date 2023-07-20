using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform gunPoint;
    [SerializeField] float bulletSpeed;
    [SerializeField] float maxReloadTime;
    private float currentReloadTime;
    private bool canShoot;
    void Start()
    {
        
    }

     
    void Update()
    {
        
    }
}

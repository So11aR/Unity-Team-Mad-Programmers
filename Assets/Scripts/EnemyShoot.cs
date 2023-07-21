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
    private void Update()
    {
        currentReloadTime -= Time.deltaTime;
        if(currentReloadTime <= 0)
        {
            canShoot = true;
            currentReloadTime = maxReloadTime;
        }
        else
        {
            canShoot = false;
        }
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        Physics.Raycast(ray, out hit);
        if(canShoot)
        {
            if(hit.transform.gameObject.tag == "Player")
            {
                GameObject bullet = Instantiate(bulletPrefab, gunPoint.position, bulletPrefab.transform.rotation);
                bullet.GetComponent<Rigidbody>().AddForce(gunPoint.forward * bulletSpeed * Time.deltaTime, ForceMode.Impulse);
                canShoot = false;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float power;
    [SerializeField] int damage;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * power;
        Destroy(gameObject, 5);
    }
    private void OnTriggerEnter(Collider collider)
    {
        
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionByEyes : MonoBehaviour
{
 
    void Start()
    {
        
    }

  
    void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward * 10);
        Physics.Raycast(ray, out hit);
        if(hit.transform.gameObject.CompareTag("Object"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(hit.transform.gameObject);
            }
        }
    }
}

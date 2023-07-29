using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionByEyes : MonoBehaviour
{
    [SerializeField] GameObject note;
  
    void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward * 10);
        Physics.Raycast(ray, out hit);
        if(hit.transform.gameObject.CompareTag("Note"))
        {
            note.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(hit.transform.gameObject);
                note.SetActive(false);
            }
        }
    }
}

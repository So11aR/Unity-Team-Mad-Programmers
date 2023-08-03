using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionByEyes : MonoBehaviour
{
    [SerializeField] GameObject note;
    [SerializeField] bool doorOpen;
    [SerializeField] Animator close, open, openDoor, closeDoor;
    [SerializeField] GameObject gun, realGun, diagnose;
  
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
                open.SetBool("open", true);
            }
        }
        if (hit.transform.gameObject.CompareTag("Gun"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(gun);
                realGun.SetActive(true);
                close.SetBool("close", true);
                open.SetBool("open", false);
            }
        }
        if (hit.transform.gameObject.CompareTag("Paper"))
        {
            diagnose.SetActive(true);
        }
        if (hit.transform.gameObject.CompareTag("Door"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                openDoor.SetBool("Open", true);
                closeDoor.SetBool("Close", false);
            }
            
        }

    }
}

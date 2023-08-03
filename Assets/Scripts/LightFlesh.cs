using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlesh : MonoBehaviour
{
    [SerializeField] GameObject _light;
    [SerializeField] float timerLight, timeOn = Random.Range(1f, 3f);
    [SerializeField] bool can = false;
    void Update()
    {
        timerLight -= Time.deltaTime;
        if(timerLight <= 0f)
        {
            _light.SetActive(false);
            can = true;
        }
        if (can)
        {
            timeOn -= Time.deltaTime;
            if(timeOn <= 0f)
            {
                _light.SetActive(true);
                 timeOn = Random.Range(0.1f, 2f);
                timerLight = Random.Range(0.1f, 2f);

            }
        }
    }
}

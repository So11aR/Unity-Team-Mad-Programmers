using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintableText : MonoBehaviour
{
    private string text;
    public float time;
    private void Start()
    {
        text = GetComponent<Text>().text;
        GetComponent<Text>().text = "";
        StartCoroutine(TextCoroutine());
    }
    IEnumerator TextCoroutine()
    {
        if (time == 0)
        {
            time = 0.03f;
        }
        foreach(char abc in text)
        {
            GetComponent<Text>().text += abc;
            yield return new WaitForSeconds(time);
        }
    }
}

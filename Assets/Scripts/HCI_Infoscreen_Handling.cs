using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HCI_Infoscreen_Handling : MonoBehaviour
{
    private int listLength;

    private float colorRed;
    private float colorGreen;
    private float colorBlue;
    private float alphaValue;
    public bool visited = false;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        visited = true;
        listLength = gameObject.transform.childCount;
        for (int i = 0; i < listLength; i++)
        {
            ColourChange(gameObject.transform.GetChild(i).gameObject);
        }
    }

    void ColourChange(GameObject childObject)
    {
        colorRed = Random.Range(0.0f, 1.0f);
        colorGreen = Random.Range(0.0f, 1.0f);
        colorBlue = Random.Range(0.0f, 1.0f);
        alphaValue = Random.Range(0.0f, 1.0f);

        childObject.GetComponent<Renderer>().material.color = new Color(colorRed, colorGreen, colorBlue, alphaValue);
    }
}

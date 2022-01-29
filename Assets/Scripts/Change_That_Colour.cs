using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_That_Colour : MonoBehaviour
{
    private float colorRed;
    private float colorGreen;
    private float colorBlue;
    private float alphaValue;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ColourChange", 0f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ColourChange()
    {
        colorRed = Random.Range(0.0f, 1.0f);
        colorGreen = Random.Range(0.0f, 1.0f);
        colorBlue = Random.Range(0.0f, 1.0f);
        alphaValue = Random.Range(0.0f, 1.0f);

        gameObject.GetComponent<Renderer>().material.color = new Color(colorRed, colorGreen, colorBlue, alphaValue);
    }
}

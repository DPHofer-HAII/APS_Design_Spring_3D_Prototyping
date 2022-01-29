using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time_Is_Money_Honey : MonoBehaviour
{
    private float timeCounter = 0.0f;

    void OnTriggerEnter(Collider other)
    {
        //Increase time counter as soon and long player is in the area
        timeCounter += Time.deltaTime;
    }

    // Update is called once per frame
    void OnTriggerExit(Collider other)
    {
        //Output time when player is leaving
        Debug.Log("You spent: " + timeCounter + " time in this area!");
    }
}

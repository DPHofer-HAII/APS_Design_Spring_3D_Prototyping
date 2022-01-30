using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time_Is_Money_Honey : MonoBehaviour
{
    private float timeCounter = 0.0f;
    private bool counter_on = false;

    void OnTriggerEnter(Collider other)
    {
        counter_on = true;
    }

    // Update is called once per frame
    void OnTriggerExit(Collider other)
    {
        //Output time when player is leaving
        counter_on = false;
        Debug.Log("You spent: " + timeCounter + " time in this area!");
        timeCounter = 0.0f;
    }

    private void FixedUpdate()
    {
        if (counter_on)
        {
            timeCounter += Time.deltaTime;
        }
    }
}

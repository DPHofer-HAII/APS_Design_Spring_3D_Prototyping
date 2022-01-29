using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class A_Load_Of_Lab : MonoBehaviour
{
    public GameObject HCI_Infoscreen;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (HCI_Infoscreen.GetComponent<HCI_Infoscreen_Handling>().visited)
        {
            SceneManager.LoadScene("HCI_LAB_ROOM");
        }
    }
}

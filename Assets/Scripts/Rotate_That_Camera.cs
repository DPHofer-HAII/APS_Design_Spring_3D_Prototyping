using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rotate_That_Camera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "MAIN_ENTRANCE_HALL")
        {
            StartCoroutine(moveHeadSpace());
        }
    }

    // Pun intended ;-)
    IEnumerator moveHeadSpace()
    {
        yield return new WaitForSeconds(2);

        for (int i = 0; i < 20; i++)
        {
            transform.Rotate(new Vector3(-30, 0, 0) * Time.deltaTime);
            Debug.Log("Rotated that head");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_For_Me_My_Darling_Precious : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * 3 * Time.deltaTime);
    }
}

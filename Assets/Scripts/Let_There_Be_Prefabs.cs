using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Let_There_Be_Prefabs : MonoBehaviour
{
    public GameObject datPrefab;
    private int prefab_count;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        prefab_count = GameObject.FindGameObjectsWithTag("PROTOTYPE_X").Length;
        if (prefab_count > 1 && Input.GetKey(KeyCode.E))
        {
            // Destroy the second PROTOTYPE_X
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        prefab_count = GameObject.FindGameObjectsWithTag("PROTOTYPE_X").Length;
        if(prefab_count > 1)
        {
            Instantiate(datPrefab, new Vector3(2, 3, 3), Quaternion.identity);
        }
    }
}

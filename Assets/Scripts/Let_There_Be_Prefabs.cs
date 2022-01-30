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
        if (Input.GetKey(KeyCode.E))
        {
            if (GameObject.FindGameObjectsWithTag("PROTOTYPE_X").Length == 2)
            {
                // Destroy the second PROTOTYPE_X_2
                var losPrefabos = GameObject.Find("PROTOTYPE_X_2");
                losPrefabos.GetComponent<Rigidbody>().useGravity = true;
                losPrefabos.GetComponent<Rigidbody>().AddForce(Vector3.left * 15);
                losPrefabos.GetComponent<AudioSource>().Play();
                Invoke("thePrefabIsDeadLongLiveThePrefab", 4);


            }
        }
    }

    void thePrefabIsDeadLongLiveThePrefab()
    {
        Destroy(GameObject.Find("PROTOTYPE_X_2"));
    }

    void OnTriggerEnter(Collider other)
    {
        
        if(GameObject.FindGameObjectsWithTag("PROTOTYPE_X").Length == 1)
        {
            var newPrefab = Instantiate(datPrefab, new Vector3(2, 3, 3), Quaternion.identity);
            newPrefab.name = "PROTOTYPE_X_2";
            Debug.Log("Initiated Prefab Gurrrrl");
        }
    }
}

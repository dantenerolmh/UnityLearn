using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeExample : MonoBehaviour
{
    public GameObject target;
    public GameObject target2;


    void Start()
    {
        InvokeRepeating("SpawnObject", 2, 1);
        InvokeRepeating("SpawnObject2", 2, 1);
    }

    void SpawnObject()
    {
        float x = Random.Range(-2.0f, 2.0f);
        float z = Random.Range(-2.0f, 2.0f);
        Instantiate(target, new Vector3(x, 2, z), Quaternion.identity);
    }

    void SpawnObject2()
    {
        float x = Random.Range(-2.0f, 2.0f);
        float z = Random.Range(-2.0f, 2.0f);
        Instantiate(target2, new Vector3(x, 2, z), Quaternion.identity);
    }

    void Update()
    {
        // Cancel all Invoke calls
        if (Input.GetButton("Fire1"))
            CancelInvoke("SpawnObject");
    }
}

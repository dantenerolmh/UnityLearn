using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleBehaviourScript_1 : MonoBehaviour
{
    private SpriteRenderer sp;

    // Start is called before the first frame update
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))   //left ctrl
        {
            float value = transform.localScale.x;

            sp.transform.localScale = new Vector3(value * -1, 1, 1);

            
        }
        if (Input.GetButtonDown("Fire2"))   //left option
        {
            float value = transform.localScale.y;

            sp.transform.localScale = new Vector3(1, value * -1, 1);

        }
        
    }
}

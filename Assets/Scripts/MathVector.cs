using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathVector : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        Vector3 result = Vector3.Cross(new Vector3(1, 2, 3), new Vector3(4, 5, 6));

        Debug.Log(result);
        //结果等于-3，6，-3
    }

}

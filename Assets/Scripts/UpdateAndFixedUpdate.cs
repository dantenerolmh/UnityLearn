using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFixedUpdate : MonoBehaviour
{
    //帧与帧的时间差是固定的
    void FixedUpdate()
    {
        Debug.Log("FixedUpdate time :" + Time.deltaTime);
    }

    //帧与帧的时间差是非固定的
    void Update()
    {
        Debug.Log("Update time :" + Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleBehaviourScript_2 : MonoBehaviour
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
        ////每一帧都读取一下鼠标的坐标
        Vector3 mousePos = Input.mousePosition;

        float r = map(mousePos.x, 0, 1920, 0.0f, 1.0f);
        float g = map(mousePos.y, 0, 1080, 0.0f, 1.0f);
        float b = map(mousePos.z, 0, 1, 0.0f, 1.0f);

        Color c = new Color(r, g, b, 1f);

        Debug.Log(r);

        sp.color = c;


    }

    static float map(float value, float low1, float high1, float low2, float high2)
    {
        return low2 + (value - low1) * (high2 - low2) / (high1 - low1);
    }
}

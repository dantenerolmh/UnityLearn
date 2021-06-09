using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//这是基类，
//也称为父类。
public class Fruit
{
    public string color;

    //这是 Fruit 类的第一个构造函数，
    //不会被任何派生类继承。
    public Fruit()
    {
        color = "orange";
        Debug.Log("调用了父类Fruit的第1个构造器");
    }

    //这是 Fruit 类的第二个构造函数，
    //不会被任何派生类继承。
    public Fruit(string newColor)
    {
        color = newColor;
        Debug.Log("调用了父类Fruit的第2个构造器");
    }

    public virtual void Chop()
    {
        Debug.Log("Fruit类：The " + color + " fruit 被切了.");
    }

    public virtual void SayHello()
    {
        Debug.Log("Fruit类：Hello, 我是个水果.");
    }
}

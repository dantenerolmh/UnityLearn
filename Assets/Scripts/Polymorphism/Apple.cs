using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//这是派生类，
//也称为子类。
public class Apple : Fruit
{
    //这是 Apple 类的第一个构造函数。
    //它立即调用父构造函数，甚至
    //在它运行之前调用。
    public Apple()
    {
        //注意 Apple 如何访问公共变量 color，
        //该变量是父 Fruit 类的一部分。
        color = "red";
        Debug.Log("调用了子类Apple的第1个构造器");
    }

    //这是 Apple 类的第二个构造函数。
    //它使用“base”关键字指定
    //要调用哪个父构造函数。
    public Apple(string newColor) : base(newColor)
    {
        //请注意，该构造函数不会设置 color，
        //因为基构造函数会设置作为参数
        //传递的 color。
        Debug.Log("调用了子类Apple的第2个构造器");
    }

    public new void Chop()
    {
        Debug.Log("Apple类的重写方法：The " + color + " 苹果被切了.");
    }

    public new void SayHello()
    {
        Debug.Log("Apple类的重写方法：Hello, 我是个苹果.");
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rito.CustomAttributes;

// 2021-01-15
// 작성자 : Rito

public class Test_Label : MonoBehaviour
{
    [Label("정수 A", EColor.White)]
    public int a;

    [Label("Float B", EColor.LightBlue)]
    public float b;

    [Label("String C", EColor.Mint)]
    public string c;

    [Label("My Game Object", EColor.LightPink)]
    public GameObject go;
}
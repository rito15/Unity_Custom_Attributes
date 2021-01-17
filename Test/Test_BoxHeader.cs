using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rito.CustomAttributes;

// 날짜 : 2021-01-17 PM 4:12:42
// 작성자 : Rito

public class Test_BoxHeader : MonoBehaviour
{
    [BoxHeader("Box A", 4)]
    public float a;
    public int b;
    public GameObject c;
    public Transform d;

    [BoxHeader("Box B", 2, BoxColor = EColor.Violet, HeaderColor = EColor.Yellow)]
    public string e;
    public char f;
}
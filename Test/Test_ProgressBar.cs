using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rito.CustomAttributes;

// 2021-01-15
// 작성자 : Rito

public class Test_ProgressBar : MonoBehaviour
{
    [ProgressBar(100, EColor.Red, EColor.White)]
    public int hp = 25;

    [ProgressBar(200, EColor.Blue, EColor.LightSky)]
    public float mp = 150f;

    [ProgressBar(1000)]
    public double exp = 300.25;
}
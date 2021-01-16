using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rito.CustomAttributes;

// 날짜 : 2021-01-17 AM 1:51:33
// 작성자 : Rito

public class Test_SpaceTop : MonoBehaviour
{
    [SpaceTop]
    public GameObject space9;

    [SpaceTop(10)]
    public GameObject space10;

    [SpaceTop(20)]
    public GameObject space20;

    [SpaceTop(50)]
    public GameObject space50;
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rito.CustomAttributes;

// 날짜 : 2021-01-17 AM 1:14:39
// 작성자 : Rito

public class Test_SpaceBottom : MonoBehaviour
{
    [SpaceBottom]
    public GameObject space9;

    [SpaceBottom(10)]
    public GameObject space10;

    [SpaceBottom(20)]
    public GameObject space20;

    [SpaceBottom(50)]
    public GameObject space50;
}
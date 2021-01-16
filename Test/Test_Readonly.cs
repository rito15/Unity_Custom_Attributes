using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rito.CustomAttributes;

// 날짜 : 2021-01-17 AM 12:52:11
// 작성자 : Rito

public class Test_Readonly : MonoBehaviour
{
    [Readonly]
    public GameObject alwaysReadonly;
        
    [Readonly(ReadOnlyOption.EditMode)]
    public float readOnlyInEditMode;

    [Readonly(ReadOnlyOption.PlayMode)]
    public Rigidbody readOnlyInPlayMode;
}

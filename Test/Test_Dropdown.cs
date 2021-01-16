using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rito.CustomAttributes;

// 2021-01-15
// 작성자 : Rito

public class Test_Dropdown : MonoBehaviour
{
    [LayerDropDown]
    public int intLayer;

    [LayerDropDown]
    public string strLayer;

    [TagDropDown]
    public string strTag;
}

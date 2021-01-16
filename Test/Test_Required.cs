using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rito.CustomAttributes;

// 2021-01-15
// 작성자 : Rito

public class Test_Required : MonoBehaviour
{
    [Required]
    public GameObject requiredGo;

    [Required]
    public Collider requiredCol;

    [Required(showMessageBox: false)]
    public Transform requiredTr;
}

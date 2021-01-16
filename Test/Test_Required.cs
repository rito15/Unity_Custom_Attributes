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
    public GameObject requiredGameObject;

    [Required]
    public Collider requiredCollider;

    [Required(ShowMessageBox = false)]
    public Transform requiredTransform;

    //[Required(ShowLogError = true)]
    public Rigidbody requiredRigidbody;
}

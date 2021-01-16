using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rito.CustomAttributes;

// 2021-01-15
// 작성자 : Rito

public class Test_AutoInject : MonoBehaviour
{
    [AutoInject(EInjection.FindObjectOfType, EModeOption.Always)]
    public Camera cam0;

    [AutoInject(EInjection.FindObjectOfType, EModeOption.EditModeOnly)]
    public Camera cam1;

    [AutoInject(EInjection.FindObjectOfType, EModeOption.PlayModeOnly)]
    public Camera cam2;

    [AutoInject(EInjection.GetComponentInChildrenOnly)]
    public Transform childTr;

    [AutoInject(EInjection.GetComponent)]
    public GameObject go;
}

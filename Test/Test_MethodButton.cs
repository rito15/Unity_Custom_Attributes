using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rito.CustomAttributes;

// 2021-01-15
// 작성자 : Rito

public class Test_MethodButton : MonoBehaviour
{
    [MethodButton("PrivateInstance", "1. Private Instance Method Button")]
    public int button1;

    [MethodButton("Public Instance", "2. Public Instance Method Button",
        ButtonColor = EColor.Black, TextColor = EColor.Yellow, WidthRatio = 0.8f,
        Height = -999, TextSize = 18, HorizontalAlignment = Alignment.Left)]
    public float button2;

    [MethodButton("Private Static", "3. Private Static Method",
        ButtonColor = EColor.White, TextColor = EColor.Red, WidthRatio = 0.7f,
        Height = 40, TextSize = 24, HorizontalAlignment = Alignment.Right)]
    public float button3;

    [MethodButton("PublicStatic  ", "4. Public Static Method",
        ButtonColor = EColor.Brown, TextColor = EColor.LightGreen, WidthRatio = 0.6f,
        Height = 30, TextSize = 21, HorizontalAlignment = Alignment.Center)]
    public float button4;

    [MethodButton("ErrorName", "Error Button", PropertyPlacement = Placement.Top)]
    public float buttonErr;

    [MethodButton("PublicStatic", "Button", PropertyPlacement = Placement.Bottom)]
    public float button5;

    private void PrivateInstance() => Debug.Log("Private Instance Method");
    public void PublicInstance()   => Debug.Log("Public Instance Method");

    private static void PrivateStatic() => Debug.Log("Private Static Method");
    public static void PublicStatic()   => Debug.Log("Public Static Method");
}


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rito.CustomAttributes;

// 2021-01-15
// 작성자 : Rito

public class Test_MemoBox : MonoBehaviour
{
    [MemoBox("1. First Line", "2. Second Line", "3. Third Line",
        BoxColor = EColor.LightBlack, TextColor = EColor.White, MarginTop = 0)]
    [MemoBox("Memo",
        BoxColor = EColor.Black, TextColor = EColor.Yellow, MarginBottom = 0, BoldText = true, PaddingLeft = 220, FontSize = 18)]
    public float a;

    [MemoBox("1234567890", "가나다라마바사아",
        BoxColor = EColor.White, TextColor = EColor.Red, FontSize = 14)]
    [MemoBox("Memo Box",
        BoxColor = EColor.LightRed, TextColor = EColor.DarkBlue, BoldText = true, MarginTop = 20f)]
    public float b;
}



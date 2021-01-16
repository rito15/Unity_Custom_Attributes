using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rito.CustomAttributes
{
    /// <summary> 
    /// <para/> 날짜 : 2020-05-16 PM 10:24:52
    /// <para/> 설명 : 원래 변수명 대신 레이블 출력 + 원하는 색상으로 변경
    /// </summary>
    
    public class LabelAttribute : PropertyAttribute
    {
        public string Label { get; private set; }
        public EColor TextColor { get; private set; } = EColor.White;

        

        public LabelAttribute(string label) => Label = label;
        public LabelAttribute(string label, EColor color) : this(label) => TextColor = color;
    }
}

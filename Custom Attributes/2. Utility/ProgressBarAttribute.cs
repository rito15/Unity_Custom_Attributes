using UnityEngine;

namespace Rito.CustomAttributes
{
    /// <summary>
    /// <para/> 2020-05-19 PM 4:47:11
    /// <para/> 현재 수치 / 최대 수치를 인스펙터에 막대 형태로 표시
    /// <para/> * 대상 : int, float
    /// </summary>
    [System.AttributeUsage(System.AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public class ProgressBarAttribute : PropertyAttribute
    {
        /*public float MinValue { get; private set; } = 0f;*/

        public float MaxValue { get; private set; }

        public EColor BarColor { get; private set; } = EColor.Gray;

        public EColor TextColor { get; private set; } = EColor.White;

        /// <summary> 값을 범위내로 강제로 제한할지 여부 </summary>
        public bool ClampInRange { get; set; } = false;

        public ProgressBarAttribute(float maxValue)
            => MaxValue = maxValue;
        public ProgressBarAttribute(float maxValue, EColor barColor) 
            : this(maxValue)
            => BarColor = barColor;
        public ProgressBarAttribute(float maxValue, EColor barColor, EColor textColor) 
            : this(maxValue, barColor)
            => TextColor = textColor;
/*
        public ProgressBarAttribute(float minValue, float maxValue)
            : this(maxValue)
            => MinValue = minValue;
        public ProgressBarAttribute(float minValue, float maxValue, EColor barColor) 
            : this(minValue, maxValue)
            => BarColor = barColor;
        public ProgressBarAttribute(float minValue, float maxValue, EColor barColor, EColor textColor) 
            : this(minValue, maxValue, barColor)
            => TextColor = textColor;*/
    }
}
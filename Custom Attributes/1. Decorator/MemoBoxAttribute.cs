using UnityEngine;

namespace Rito.CustomAttributes
{
    /// <summary>
    /// 2021. 01. 15.
    /// <para/> 프로퍼티 상단에 박스 메모 작성
    /// </summary>
    [System.AttributeUsage(System.AttributeTargets.Field, AllowMultiple = true, Inherited = false)]
    public class MemoBoxAttribute : PropertyAttribute
    {
        public string[] Contents { get; private set; } = new string[] { "" };

        public int FontSize { get; set; } = 12;
        public int LineSpacing { get; set; } = 2;

        public EColor TextColor { get; set; } = EColor.White;
        public EColor BoxColor { get; set; } = EColor.Black;

        public float MarginTop { get; set; } = 5f;
        public float MarginBottom { get; set; } = 5f;

        /// <summary> Top, Bottom Padding </summary>
        public float Padding { get; set; } = 5f;
        public float PaddingLeft { get; set; } = 5f;

        public bool BoldText { get; set; } = false;

        // 색상 직접 결정할 수 있게 해주는 색상 선택 도구 노출
        //public bool UseColorPicker { get; set; } = true;

        public MemoBoxAttribute(params string[] contents)
            => Contents = contents;
    }
}

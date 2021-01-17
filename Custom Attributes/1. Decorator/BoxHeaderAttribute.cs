
using UnityEngine;

namespace Rito.CustomAttributes
{
    /// <summary>
    /// 2020. 05. 15.
    /// <para/> 헤더 한 줄 작성 + 여러 필드를 하나의 컬러 박스로 묶어주기
    /// </summary>
    public class BoxHeaderAttribute : HeaderAttributeBase
    {
        public string HeaderText { get; private set; } = "";

        // 몇 줄의 필드를 묶을 것인지 결정
        public int FieldCount { get; private set; } = 0;

        public EColor HeaderColor { get; set; } = EColor.White;
        public EColor BoxColor { get; set; } = EColor.Black;

        public float Alpha { get; set; } = 0.4f;

        // 추가 하단 높이
        public float BottomHeight { get; set; } = 0f;

        // 색상 직접 결정할 수 있게 해주는 색상 선택 도구 노출
        //public bool UseColorPicker { get; set; } = false;

        public BoxHeaderAttribute(string header, int fieldCount)
        {
            HeaderText = header;
            FieldCount = fieldCount;
        }
    }
}

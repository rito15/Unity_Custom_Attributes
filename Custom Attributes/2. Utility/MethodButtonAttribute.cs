using UnityEngine;

namespace Rito.CustomAttributes
{
    /// <summary>
    /// <para/> 2020-05-18 AM 1:11:23
    /// <para/> 클릭하면 메소드를 실행하는 버튼을 인스펙터에 표시합니다.
    /// <para/> * 해당 스크립트에 작성된 메소드 이름을 파라미터로 입력합니다.
    /// <para/> * 매개변수가 없는 메소드만 등록할 수 있습니다.
    /// <para/> * 여러 개의 스트링을 입력할 경우, 각각의 버튼이 생성됩니다.
    /// <para/> * 지정된 필드는 기본적으로 숨겨지며, ShowField 옵션을 통해 나타낼 수 있습니다.
    /// </summary>
    [System.AttributeUsage(System.AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public class MethodButtonAttribute : PropertyAttribute
    {
        /// <summary> 연결할 메소드명(공백 자동 제거) </summary>
        public string MethodName { get; private set; }

        /// <summary> 버튼에 보여줄 텍스트 </summary>
        public string Text { get; private set; }


        public EColor ButtonColor { get; set; } = EColor.None;

        public EColor TextColor { get; set; } = EColor.White;


        /// <summary> 글자 크기(최소 12) </summary>
        public int TextSize { get; set; } = 12;

        /// <summary> 버튼 너비의 최대 길이 대비 비율(0.0 ~ 1.0) </summary>
        public float WidthRatio { get; set; } = 1.0f;

        /// <summary> 버튼의 높이(최소 18) </summary>
        public float Height { get; set; } = 18f;

        /// <summary> 원래 프로퍼티의 위치(기본값 : 숨기기) </summary>
        public Placement PropertyPlacement { get; set; } = Placement.Hidden;

        /// <summary> 버튼 좌우 정렬 </summary>
        public Alignment HorizontalAlignment { get; set; } = Alignment.Center;

        public MethodButtonAttribute(string methodName, string buttonText)
        {
            MethodName = methodName;
            Text = buttonText;
        }
    }

    public enum Placement
    {
        Hidden,
        Top,
        Bottom
    }
    public enum Alignment
    {
        Left,
        Center,
        Right
    }
}
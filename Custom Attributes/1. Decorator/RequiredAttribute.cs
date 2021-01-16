using UnityEngine;

namespace Rito.CustomAttributes
{
    /// <summary>
    /// <para/> 2020-05-19 PM 8:11:06
    /// <para/> 해당 필드가 반드시 초기화되어야 한다고 경고박스로 알려주기
    /// <para/> * 컴포넌트 타입에만 사용 가능
    /// </summary>
    [System.AttributeUsage(System.AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public class RequiredAttribute : PropertyAttribute
    {
        /// <summary> 인포, 경고 박스를 표시할지 여부 </summary>
        public bool ShowMessageBox { get; set; } = true;

        /// <summary> Null일 때 디버그 에러를 호출할지 여부 </summary>
        public bool ShowLogError { get; set; } = false;

        public RequiredAttribute() { }
    }
}
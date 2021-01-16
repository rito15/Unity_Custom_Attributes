using UnityEngine;

namespace Rito.CustomAttributes
{
    /// <summary>
    /// <para/> 2020-05-18 PM 9:12:43
    /// <para/> Component 상속 타입 변수들에 참조를 자동으로 초기화 해주며
    /// <para/> 초기화 이후 애트리뷰트를 지워도 참조를 손실하지 않습니다.
    /// </summary>
    [System.AttributeUsage(System.AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public class AutoInjectAttribute : PropertyAttribute
    {
        public EInjection Option { get; private set; }

        public EModeOption ModeOption { get; private set; } = EModeOption.Always;


        public AutoInjectAttribute(EInjection option) => Option = option;

        public AutoInjectAttribute(EInjection option, EModeOption mode) : this(option)
            => ModeOption = mode;
    }

    // 애트리뷰트에서 선택할 옵션
    public enum EInjection
    {
        GetComponent,

        GetComponentInChildren,
        /// <summary> 자기 게임오브젝트를 제외하고 자식 게임오브젝트들을 대상으로 수행합니다. </summary>
        GetComponentInChildrenOnly,
        /// <summary> 비활성화된 모든 자식 게임오브젝트를 포함하여 수행합니다. </summary>
        GetComponentInAllChildren,

        GetComponentInparent,
        /// <summary> 자기 게임오브젝트를 제외하고 부모 게임오브젝트들을 대상으로 수행합니다. </summary>
        GetComponentInparentOnly,

        FindObjectOfType
    }

    // 실행할 타이밍
    public enum EModeOption
    {
        Always,
        EditModeOnly,
        PlayModeOnly
    }
}
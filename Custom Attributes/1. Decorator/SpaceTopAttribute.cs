using UnityEngine;

namespace Rito.CustomAttributes
{
    /// <summary>
    /// <para/> 날짜 : 2021-01-17 AM 1:47:50
    /// <para/> 필드 상단 공백
    /// <para/> * 배열에는 작동하지 않음
    /// </summary>
    [System.AttributeUsage(System.AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public class SpaceTopAttribute : PropertyAttribute
    {
        public float SpaceHeight { get; set; }

        public SpaceTopAttribute(float space = 9f) => SpaceHeight = space.Ex_ClampMin(0f);
    }
}
#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

namespace Rito.CustomAttributes
{
    /// <summary>
    /// <para/> 날짜 : 2021-01-17 AM 1:48:56
    /// <para/> 필드 상단 공백
    /// </summary>
    [CustomPropertyDrawer(typeof(SpaceTopAttribute), true)]
    public class SpaceTopAttributeDrawer : DecoratorDrawer
    {
        public override float GetHeight() => (attribute as SpaceTopAttribute).SpaceHeight;
    }
}
#endif
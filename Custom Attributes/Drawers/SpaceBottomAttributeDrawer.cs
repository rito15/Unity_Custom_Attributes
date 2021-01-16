#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

namespace Rito.CustomAttributes
{
    /// <summary>
    /// <para/> 날짜 : 2020-05-20 AM 12:32:55
    /// <para/> 필드 하단 공백
    /// </summary>
    [CustomPropertyDrawer(typeof(SpaceBottomAttribute), true)]
    public class SpaceBottomAttributeDrawer : PropertyDrawer
    {
        SpaceBottomAttribute Atr => attribute as SpaceBottomAttribute;

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            if (property.isArray)
            {
                return EditorGUI.GetPropertyHeight(property, label, true);
            }
            else
                return EditorGUI.GetPropertyHeight(property, label, true) + Atr.SpaceHeight;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            Rect rect = new Rect(position.x, position.y, position.width, 
                EditorGUI.GetPropertyHeight(property, label, true));

            EditorGUI.PropertyField(rect, property, label, true);
        }

    }
}
#endif
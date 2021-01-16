#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Rito.CustomAttributes
{
    [CustomPropertyDrawer(typeof(LabelAttribute), true)]
    public class LabelAttributeDrawer : PropertyDrawer
    {
        LabelAttribute Atr => attribute as LabelAttribute;

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property, label, true);
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (fieldInfo.FieldType.Ex_IsArrayOrListType())
            {
                Debug.LogWarning("배열, 리스트 타입에는 사용할 수 없습니다");
                EditorGUI.PropertyField(position, property, label, true);
                return;
            }


            // 1. 예전 스타일 기억
            Color old1 = EditorStyles.label.normal.textColor;
            Color old2 = EditorStyles.label.hover.textColor;
            Color old3 = EditorStyles.label.focused.textColor;

            // 2. 원하는 스타일 적용
            Color textColor = Atr.TextColor.Ex_Convert();
            EditorStyles.label.normal.textColor = textColor;
            EditorStyles.label.hover.textColor = textColor;
            EditorStyles.label.focused.textColor = textColor;

            // 3. 원하는 컨트롤에 적용
            EditorGUI.PropertyField(position, property, new GUIContent(Atr.Text), true);

            // 4. 다시 예전 스타일 복원
            EditorStyles.label.normal.textColor = old1;
            EditorStyles.label.hover.textColor = old2;
            EditorStyles.label.focused.textColor = old3;

        }
    }
}
#endif
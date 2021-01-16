#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

namespace Rito.CustomAttributes
{
    /// <summary>
    /// <para/> 2020-05-18 AM 12:07:17
    /// <para/> 스트링 - 사용 가능한 레이어 드롭다운 표시
    /// </summary>
    [CustomPropertyDrawer(typeof(LayerDropDownAttribute), true)]
    public class LayerDropDownAttributeDrawer : PropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property, label, true);
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (EditorHelper.CheckDuplicatedAttribute<DropDownAttributeBase>(fieldInfo))
            {
                EditorGUI.HelpBox(position, "DropDownAttribute는 중복 사용될 수 없습니다", MessageType.Error);
                return;
            }

            if (!property.propertyType.Equals(SerializedPropertyType.Integer) &&
                !property.propertyType.Equals(SerializedPropertyType.String))
            {
                string strErr = "[LayerDropDownAttribute] int 또는 string 타입에만 적용할 수 있습니다.";

                EditorGUI.PropertyField(position, property, label, true);
                EditorGUILayout.HelpBox(strErr, MessageType.Error);
                Debug.LogError(strErr);
                return;
            }

            float ratio = 0.4f;
            float widthLeft = position.width * ratio;
            float widthRight = position.width * (1 - ratio);

            Rect rectLeft = new Rect(position.x, position.y, widthLeft, position.height);
            Rect rectRight = new Rect(position.x + widthLeft, position.y, widthRight, position.height);

            // 1. 좌측 레이블 그리기
            EditorGUI.LabelField(rectLeft, label);

            // 2. 우측 팝업 그리기 + 값 할당
            switch (property.propertyType)
            {
                case SerializedPropertyType.Integer:
                    property.intValue = EditorGUI.LayerField(rectRight, property.intValue); ;
                    break;

                case SerializedPropertyType.String:
                    int layerIndex = LayerMask.NameToLayer(property.stringValue);
                    property.stringValue = LayerMask.LayerToName(EditorGUI.LayerField(rectRight, layerIndex));
                    break;
            }
        }
    }
}
#endif
#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

namespace Rito.CustomAttributes
{
    /// <summary>
    /// <para/> 2020-05-19 PM 4:48:45
    /// <para/> 현재 수치 / 최대 수치를 인스펙터에 막대 형태로 표시
    /// <para/> * 대상 : int, float, double
    /// </summary>
    [CustomPropertyDrawer(typeof(ProgressBarAttribute), true)]
    public class ProgressBarAttributeDrawer : PropertyDrawer
    {
        ProgressBarAttribute Atr => attribute as ProgressBarAttribute;

        private float Height { get; set; } = 20f;

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            //return EditorGUI.GetPropertyHeight(property, label, true);
            return Height * 3f;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            float minValue = 0f;
            float maxValue = Atr.MaxValue.Ex_ClampMin(minValue);
            float currentValue;
            Rect propRect = new Rect(position.x, position.y,          position.width, Height);
            Rect backRect = new Rect(position.x, position.y + Height, position.width, Height * 1.5f);

            switch (property.propertyType)
            {
                case SerializedPropertyType.Integer:

                    // 값 범위 강제 제한
                    if (Atr.ClampInRange)
                        property.intValue = property.intValue.Ex_Clamp((int)minValue, (int)maxValue);
                    currentValue = property.intValue;
                    break;

                case SerializedPropertyType.Float:

                    if (Atr.ClampInRange)
                        property.floatValue = property.floatValue.Ex_Clamp(minValue, maxValue);
                    currentValue = property.floatValue;
                    break;

                default:
                    EditorGUI.PropertyField(propRect, property, label, true);
                    EditorHelper.ColorErrorBox(backRect, $"[ProgressBar - Error] 숫자 타입에만 사용할 수 있습니다.\n대상 타입 : {property.type} ");
                    return;
            }

            
            // 바 가로길이 구하기
            float ratio = (currentValue / maxValue).Ex_Clamp(0f, 1f);
            Rect barRect = new Rect(position.x, position.y + Height, position.width * ratio, Height * 1.5f);

            // 기본 필드 그리기
            if (Atr.ClampInRange)
                label.text = $"{label.text} [Clamped]";
            EditorGUI.PropertyField(propRect, property, label, true);

            // 바 그리기
            EditorGUI.DrawRect(backRect, Color.black);
            EditorGUI.DrawRect(barRect, Atr.BarColor.Ex_Convert());

            // 텍스트 그리기
            var textStyle = new GUIStyle(GUI.skin.label);
            textStyle.fontStyle = FontStyle.Bold;
            textStyle.normal.textColor = Atr.TextColor.Ex_Convert();
            textStyle.fontSize = 20;
            textStyle.alignment = TextAnchor.MiddleCenter;

            EditorGUI.LabelField(backRect, $"{currentValue} / {maxValue}", textStyle);
        }
    }
}
#endif
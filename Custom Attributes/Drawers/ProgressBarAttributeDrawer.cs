#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

namespace Rito.CustomAttributes
{
    /// <summary>
    /// <para/> 2020-05-19 PM 4:48:45
    /// <para/> ���� ��ġ / �ִ� ��ġ�� �ν����Ϳ� ���� ���·� ǥ��
    /// <para/> * ��� : int, float, double
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

                    // �� ���� ���� ����
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
                    EditorHelper.ColorErrorBox(backRect, $"[ProgressBar - Error] ���� Ÿ�Կ��� ����� �� �ֽ��ϴ�.\n��� Ÿ�� : {property.type} ");
                    return;
            }

            
            // �� ���α��� ���ϱ�
            float ratio = (currentValue / maxValue).Ex_Clamp(0f, 1f);
            Rect barRect = new Rect(position.x, position.y + Height, position.width * ratio, Height * 1.5f);

            // �⺻ �ʵ� �׸���
            if (Atr.ClampInRange)
                label.text = $"{label.text} [Clamped]";
            EditorGUI.PropertyField(propRect, property, label, true);

            // �� �׸���
            EditorGUI.DrawRect(backRect, Color.black);
            EditorGUI.DrawRect(barRect, Atr.BarColor.Ex_Convert());

            // �ؽ�Ʈ �׸���
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
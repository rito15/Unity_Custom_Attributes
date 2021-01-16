#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
using System;
using System.Reflection;

namespace Rito.CustomAttributes
{
    /// <summary>
    /// <para/> 2020-05-18 AM 1:12:28
    /// <para/> 인스펙터에 메소드 버튼 표시
    /// </summary>
    [CustomPropertyDrawer(typeof(MethodButtonAttribute), true)]
    public class MethodButtonAttributeDrawer : PropertyDrawer
    {
        MethodButtonAttribute Atr => attribute as MethodButtonAttribute;

        // 글자 크기 : 최소 12
        private int TextSize => (Atr.TextSize < 12 ? 12 : Atr.TextSize);

        // 버튼 높이 : 최소한 글자크기 * 1.5
        private float BtnHeight => (Atr.Height < TextSize * 1.5f ? TextSize * 1.5f : Atr.Height);

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            float propHeight = Atr.PropertyPlacement == Placement.Hidden ? 0f : 18f; // 프로퍼티의 높이
            return propHeight + BtnHeight;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EColor eBtnColor = Atr.ButtonColor;

            Color textColor = Atr.TextColor.Ex_Convert();
            Color btnColor = eBtnColor.Ex_Convert();

            string text = Atr.Text;

            float propWidth = position.width;
            float propHeight = 18f;
            float propX = position.x;

            float btnWidthRatio = Atr.WidthRatio;
            btnWidthRatio.Ex_ClampRef(0f, 1f); // 비율 : 0 ~ 1 사이로 제한

            float btnWidth = position.width * btnWidthRatio;

            float btnMarginX = (position.width - btnWidth) * 0.5f;
            float btnX = position.x;
            switch (Atr.HorizontalAlignment)
            {
                case Alignment.Center:
                    btnX += btnMarginX;
                    break;

                case Alignment.Right:
                    btnX += btnMarginX * 2f;
                    break;
            }

            // 지금 그릴 컨트롤의 Y 위치
            float currentY = position.y;

            // ==========================================================================

            // 원래 프로퍼티 배치가 위쪽일 때 표시
            if (Atr.PropertyPlacement.Equals(Placement.Top))
            {
                EditorGUI.PropertyField(new Rect(propX, currentY, propWidth, propHeight),
                    property, label, true);

                currentY += propHeight;
            }

            Rect btnRect = new Rect(btnX, currentY, btnWidth, BtnHeight);
            var target = property.serializedObject.targetObject;

            // 버튼 텍스트 색상 지정
            var buttonStyle = new GUIStyle(GUI.skin.button);
            buttonStyle.normal.textColor = textColor;
            buttonStyle.hover.textColor  = textColor;
            buttonStyle.fontSize = TextSize;

            string methodName = Atr.MethodName.Replace(" ", "");

            var method = fieldInfo.DeclaringType.GetMethod(methodName,
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static,
                null,
                new Type[] { },
                null
                );

            if (method == null)
            {
                Rect errRect = new Rect(position.x, currentY, position.width, BtnHeight);
                EditorGUI.HelpBox(errRect, $"Error : Not Existed Method Name \"{methodName}\"", MessageType.Error);
            }
            else
            {
                // 배경 색상 지정
                if (!eBtnColor.Equals(EColor.None))
                {
                    // 버튼 색상은 내부적으로 1/3 정도로 적용되는듯
                    // 그래서 3배를 해줌
                    Color newBtnColor = new Color(
                        btnColor.r * 3f, btnColor.g * 3f, btnColor.b * 3f, 1.0f);

                    using (new BackgroundColorScope(newBtnColor))
                    {
                        if (GUI.Button(btnRect, text, buttonStyle))
                            method.Invoke(target, null);
                    }
                }
                // 무색 (원래 버튼 색)
                else
                {
                    if (GUI.Button(btnRect, text, buttonStyle))
                        method.Invoke(target, null);
                }
            }
            currentY += BtnHeight;

            // 원래 필드 배치가 아래쪽일 때 표시
            if (Atr.PropertyPlacement.Equals(Placement.Bottom))
            {
                EditorGUI.PropertyField(new Rect(propX, currentY, propWidth, propHeight),
                    property, label, true);
            }
        }
    }
}
#endif
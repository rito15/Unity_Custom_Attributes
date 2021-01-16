#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

namespace Rito.CustomAttributes
{
    /// <summary>
    /// 2020. 05. 15.
    /// <para/> 헤더 한 줄 작성 + 여러 필드를 하나의 컬러 박스로 묶어주기
    /// </summary>
    [CustomPropertyDrawer(typeof(MemoBoxAttribute))]
    public class MemoBoxAttributeDrawer : DecoratorDrawer
    {
        MemoBoxAttribute Atr => attribute as MemoBoxAttribute;

        float LineHeight => Atr.FontSize + Atr.LineSpacing ;

        public override float GetHeight()
        {
            float contentHeight = Atr.Contents.Length * LineHeight;
            return contentHeight + Atr.MarginTop + Atr.MarginBottom + Atr.PaddingTop + Atr.PaddingBottom;
        }

        public override void OnGUI(Rect position)
        {
            float textHeight = Atr.Contents.Length * LineHeight;
            float boxHeight = textHeight + Atr.PaddingTop + Atr.PaddingBottom;

            float boxWidth = position.width;
            float textWidth = boxWidth - Atr.PaddingLeft;

            float boxX = position.x;
            float textX = boxX + Atr.PaddingLeft;

            float boxY = position.y + Atr.MarginTop;
            float textY = boxY + Atr.PaddingTop;

            Rect boxRect = new Rect(boxX, boxY, boxWidth, boxHeight);

            Color textColor = EColorConverter.Convert(Atr.TextColor);
            Color boxColor = EColorConverter.Convert(Atr.BoxColor);

            EditorGUI.DrawRect(boxRect, boxColor);

            GUIStyle labelStyle = Atr.BoldText ? EditorStyles.boldLabel : EditorStyles.label;

            // Remember Olds
            Color oldStyleTextColor = labelStyle.normal.textColor;
            int oldTextSize = labelStyle.fontSize;

            // Custom Text Color
            labelStyle.normal.textColor = textColor;
            labelStyle.fontSize = Atr.FontSize;

            // Header Label
            float curPosY = textY;
            foreach (var text in Atr.Contents)
            {
                Rect curRect = new Rect(textX, curPosY, textWidth, LineHeight);

                EditorGUI.LabelField(curRect, text, labelStyle);
                curPosY += LineHeight;
            }

            // Restore Olds
            labelStyle.normal.textColor = oldStyleTextColor;
            labelStyle.fontSize = oldTextSize;
        }
    }
}
#endif
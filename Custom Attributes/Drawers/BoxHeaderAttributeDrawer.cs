#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

namespace Rito.CustomAttributes
{
    /// <summary>
    /// 2020. 05. 15.
    /// <para/> 헤더 한 줄 작성 + 여러 필드를 하나의 컬러 박스로 묶어주기
    /// </summary>
    [CustomPropertyDrawer(typeof(BoxHeaderAttribute))]
    public class BoxHeaderAttributeDrawer : DecoratorDrawer
    {
        BoxHeaderAttribute Atr => attribute as BoxHeaderAttribute;

        public override float GetHeight() => 35f; // 5f : 헤더 <-> 첫번째 컨트롤 사이 간격

        public override void OnGUI(Rect position)
        {
            float headerHeight = 20f;
            float oneControlHeight = 20f;
            float boxHeight =
                headerHeight +
                oneControlHeight * (Atr.FieldCount)
                + Atr.BottomHeight + 5f; // 5f : 헤더 <-> 첫번째 컨트롤 사이 간격

            float X = position.x - 5f;
            float Y = position.y + (GetHeight() - headerHeight - 5f); // 5f : 헤더 <-> 첫번째 컨트롤 사이 간격
            float width = position.width + 5f;

            Rect headerRect     = new Rect(X,      Y, width, headerHeight);
            Rect headerTextRect = new Rect(X + 5f, Y, width, headerHeight);
            Rect boxRect        = new Rect(X,      Y, width, boxHeight);

            Color hCol = Atr.HeaderColor.Ex_Convert();
            Color bCol = Atr.BoxColor.Ex_Convert();

            // 색상 보정
            bCol = bCol.Ex_SetAlpha(Atr.Alpha).Ex_PlusRGB(-0.1f);

            // Header Small Box Color
            EditorGUI.DrawRect(headerRect, new Color(bCol.r, bCol.g, bCol.b, 0.5f));

            // Content Box Color
            // - 필드 카운트가 존재할 경우
            if (Atr.FieldCount > 0)
            {
                EditorGUI.DrawRect(boxRect, bCol);
            }

            // Header Style
            GUIStyle headerStyle = new GUIStyle(EditorStyles.boldLabel);
            headerStyle.normal.textColor = hCol;
            headerStyle.fontSize = 15;

            // Header Label
            EditorGUI.LabelField(headerTextRect, Atr.HeaderText, headerStyle);
        }
    }
}
#endif
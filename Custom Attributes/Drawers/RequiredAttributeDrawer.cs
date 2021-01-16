#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

namespace Rito.CustomAttributes
{
    /// <summary>
    /// <para/> 날짜 : 2020-05-19 PM 8:21:20
    /// <para/> 해당 필드가 반드시 초기화되어야 한다고 경고박스로 알려주기
    /// <para/> * 컴포넌트 타입에만 사용 가능
    /// </summary>
    [CustomPropertyDrawer(typeof(RequiredAttribute), true)]
    public class RequiredAttributeDrawer : PropertyDrawer
    {
        RequiredAttribute Atr => attribute as RequiredAttribute;

        System.Type FieldType => fieldInfo.FieldType;

        float Height => 18f;

        private bool IsEmpty(SerializedProperty property)
            => property.objectReferenceValue == null ||
                property.objectReferenceValue.GetType().Ex_IsChildOrEqualsTo(FieldType) == false;

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return (IsEmpty(property) && Atr.ShowMessageBox ? Height * 2.5f : Height);
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            float x = position.x;
            float y = position.y;
            float width = position.width;

            Rect firstThird = new Rect(x, y + Height * 0.5f, width, Height);
            Rect midThird   = new Rect(x, y + Height * 1.5f, width, Height);
            Rect errorRect  = new Rect(x, y + Height * 0.5f, width, Height * 2f);

            // 타입 제한 : 컴포넌트, 게임오브젝트
            if (FieldType.Ex_IsChildOrEqualsTo(typeof(Component)) == false && 
                FieldType.IsEquivalentTo(typeof(GameObject)) == false)
            {
                // 배열, 리스트면 크기를 0으로 고정하고 콘솔 에러 메시지
                if (FieldType.Ex_IsArrayOrListType())
                {
                    fieldInfo.SetValue(property.serializedObject.targetObject, null);
                    Debug.LogError("[Required] 배열 또는 리스트에는 사용할 수 없습니다.");
                }

                if (!Atr.ShowMessageBox)
                {
                    EditorHelper.ColorErrorBox(position, $"[Required - Error] Component 타입이 아닙니다. - 대상 타입 : {FieldType}");
                }
                else
                {
                    EditorHelper.ColorErrorBox(errorRect, $"[Required - Error] Component 타입이 아닙니다.\n대상 타입 : {FieldType}");
                }

                return;
            }


            Rect rect = position;
            Color contentColor = new Color(0.3f, 1f, 0.2f);

            // 1-1. 경고 - null이거나 MisMatch
            // Type Mismatch까지 검사(참조가 들어있는 상태에서 스크립트 내의 타입을 바꿔버린 경우)
            if (IsEmpty(property))
            {
                if (Atr.ShowMessageBox)
                {
                    // ★ Missing Reference 잡아주기
                    property.objectReferenceValue = null;

                    EditorHelper.ColorErrorBox(firstThird, "[Required Component]");
                    rect = midThird;

                    if (Atr.ShowLogError)
                        Debug.LogError($"[Required Component] - GameObject : {property.serializedObject.targetObject.name}, " +
                            $"Field : {fieldInfo.Name}");
                }
                contentColor = new Color(1f, 0.3f, 0.2f);
            }

            // 1-2. 평소 상태
            // do nothing

            var col = GUI.contentColor;
            GUI.contentColor = contentColor;
            EditorGUI.PropertyField(rect, property, label, true);
            GUI.contentColor = col;
        }
    }
}
#endif
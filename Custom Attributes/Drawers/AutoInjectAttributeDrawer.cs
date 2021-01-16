#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
using System;

namespace Rito.CustomAttributes
{
    /// <summary>
    /// <para/> 2020-05-18 PM 9:15:30
    /// <para/> Component 상속 타입 변수들에 자동으로 초기화해주는 기능
    /// </summary>
    [CustomPropertyDrawer(typeof(AutoInjectAttribute), true)]
    public class AutoInjectAttributeDrawer : PropertyDrawer
    {
        AutoInjectAttribute Atr => attribute as AutoInjectAttribute;

        private float Height { get; set; } = 18f;

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            //return EditorGUI.GetPropertyHeight(property, label, true);
            return Height * 2.5f;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            Rect infoRect = new Rect(position.x, position.y + Height * 0.5f, position.width, Height);
            Rect propRect = new Rect(position.x, position.y + Height * 1.5f, position.width, Height);

            Rect ErrorRect = new Rect(position.x, position.y + Height * 0.5f, position.width, Height * 2f);

            Type fieldType = fieldInfo.FieldType;

            // 컴포넌트 상속 타입이 아닌 타입 - 에러박스
            if (fieldType.IsSubclassOf(typeof(Component)) == false)
            {
                // 배열, 리스트면 크기를 0으로 고정하고 콘솔 에러 메시지
                if (fieldType.Ex_IsArrayOrListType())
                {
                    fieldInfo.SetValue(property.serializedObject.targetObject, null);
                    Debug.LogError("[AutoInject] 배열 또는 리스트에는 사용할 수 없습니다.");
                }

                // 그 외의 경우, 인스펙터에 큼지막한 에러 박스
                EditorHelper.ColorErrorBox(ErrorRect, $"Error : Component를 상속하는 타입에만 사용할 수 있습니다\n" +
                    $"이름 : {fieldInfo.Name}, 타입 : {fieldType}");
                return;
            }


            // 컴포넌트 타입 - 올바르게 동작 ===========================================================


            // 실행모드 옵션 제한을 설정한 경우
            switch (Atr.ModeOption)
            {
                case EModeOption.EditModeOnly when EditorApplication.isPlaying:
                    EditorHelper.ColorWarningBox(infoRect, $"{Atr.Option} -  에디터 모드에서만 동작합니다");
                    EditorGUI.PropertyField(propRect, property, label, true);
                    return;

                case EModeOption.PlayModeOnly when !EditorApplication.isPlaying:
                    EditorHelper.ColorWarningBox(infoRect, $"{Atr.Option} -  플레이 모드에서만 동작합니다");
                    EditorGUI.PropertyField(propRect, property, label, true);
                    return;
            }

            // 인스펙터에서 지정한 옵션별로 동작 : null일 때만 실행하게 해서 에디터 성능 최적화
            if (property.objectReferenceValue == null ||
                // Type Mismatch까지 검사(참조가 들어있는 상태에서 스크립트 내의 타입을 바꿔버린 경우)
                property.objectReferenceValue.GetType().Ex_IsChildOrEqualsTo(fieldType) == false)
            {
                Component target = property.serializedObject.targetObject as Component;

                switch (Atr.Option)
                {
                    case EInjection.GetComponent:
                        property.objectReferenceValue = target.GetComponent(fieldType);
                        break;

                    case EInjection.GetComponentInChildren:
                        property.objectReferenceValue = target.GetComponentInChildren(fieldType);
                        break;

                    case EInjection.GetComponentInChildrenOnly:
                        property.objectReferenceValue = target.Ex_GetComponentInChildrenOnly(fieldType);
                        break;

                    case EInjection.GetComponentInAllChildren:
                        property.objectReferenceValue = target.Ex_GetComponentInAllChildren(fieldType);
                        break;

                    case EInjection.GetComponentInparent:
                        property.objectReferenceValue = target.GetComponentInParent(fieldType);
                        break;

                    case EInjection.GetComponentInparentOnly:
                        property.objectReferenceValue = target.Ex_GetComponentInParentOnly(fieldType);
                        break;

                    case EInjection.FindObjectOfType:
                        property.objectReferenceValue = UnityEngine.Object.FindObjectOfType(fieldType);
                        break;
                }
            }

            // 실행 결과 - 성공
            if (property.objectReferenceValue != null)
            {
                EditorHelper.ColorInfoBox(infoRect, Color.green, $"{Atr.Option}");
            }
            // 실행 결과 - 실패(대상이 없음)
            else
            {
                EditorHelper.ColorWarningBox(infoRect, $"{Atr.Option} - Failed : 대상을 찾지 못했습니다");
            }
            EditorGUI.PropertyField(propRect, property, label, true);
        }
    }
}
#endif
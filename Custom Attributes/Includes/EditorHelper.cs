#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

namespace Rito.CustomAttributes
{
    /// <summary> 에디터 전용 유틸리티 클래스 </summary>
    public static class EditorHelper
    {
        public static bool CheckDuplicatedAttribute<T>(System.Reflection.FieldInfo fieldInfo) where T : PropertyAttribute
        {
            var customAttributes = fieldInfo.GetCustomAttributes(typeof(T), true);
            if (customAttributes != null && customAttributes.Length > 1)
                return true;

            return false;
        }

        /// <summary> 인포 박스에 색상 칠해서 인스펙터 표시  </summary>
        public static void ColorInfoBox(in Rect position, in Color color, in string msg)
        {
            using (new BackgroundColorScope(color))
            {
                EditorGUI.HelpBox(position, msg, MessageType.Info);
            }
        }

        /// <summary> 경고 박스에 색상 칠해서 인스펙터 표시  </summary>
        public static void ColorWarningBox(in Rect position, in Color color, in string msg)
        {
            using (new BackgroundColorScope(color))
            {
                EditorGUI.HelpBox(position, msg, MessageType.Warning);
            }
        }
        /// <summary> 경고 박스에 노란 색상 칠해서 인스펙터 표시  </summary>
        public static void ColorWarningBox(in Rect position, in string msg)
        {
            using (new BackgroundColorScope(Color.yellow))
            {
                EditorGUI.HelpBox(position, msg, MessageType.Warning);
            }
        }

        /// <summary> 에러 박스에 색상 칠해서 인스펙터 표시  </summary>
        public static void ColorErrorBox(in Rect position, in Color color, in string msg)
        {
            using (new BackgroundColorScope(color))
            {
                EditorGUI.HelpBox(position, msg, MessageType.Error);
            }
        }
        /// <summary> 에러 박스에 연빨강 색상 칠해서 인스펙터 표시  </summary>
        public static void ColorErrorBox(in Rect position, in string msg)
        {
            using (new BackgroundColorScope(new Color(1.00f, 0.50f, 0.50f)))
            {
                EditorGUI.HelpBox(position, msg, MessageType.Error);
            }
        }
    }
}
#endif
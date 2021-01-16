using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rito.CustomAttributes
{
    /// <summary> 
    /// <para/> 날짜 : 2020-05-16 PM 9:13:42
    /// <para/> 설명 : Color 구조체 확장
    /// <para/> 
    /// </summary>
    public static class ColorExtension
    {
        /// <summary>
        /// <para/> EColor -> Color 변환
        /// </summary>
        public static Color Ex_Convert(this EColor eColor)
            => EColorConverter.Convert(eColor);

        /// <summary>
        /// <para/> Alpha 값 변경 후 리턴
        /// </summary>
        public static Color Ex_SetAlpha(this Color color, float alpha)
        {
            if (alpha > 1) alpha = 1f;
            else if (alpha < 0) alpha = 0f;

            return new Color(color.r, color.g, color.b, alpha);
        }

        /// <summary>
        /// <para/> RGB값 더한 후 리턴
        /// </summary>
        public static Color Ex_Plus(this Color color, float r, float g, float b)
        {
            return new Color(color.r + r, color.g + g, color.b + b);
        }

        /// <summary>
        /// <para/> RGBA값 더한 후 리턴
        /// </summary>
        public static Color Ex_Plus(this Color color, float r, float g, float b, float a)
        {
            return new Color(color.r + r, color.g + g, color.b + b, color.a + a);
        }

        /// <summary>
        /// <para/> RGB값 더한 후 리턴
        /// </summary>
        public static Color Ex_PlusRGB(this Color color, float rgb)
        {
            return new Color(color.r + rgb, color.g + rgb, color.b + rgb, color.a);
        }

        /// <summary>
        /// <para/> RGBA값 더한 후 리턴
        /// </summary>
        public static Color Ex_PlusRGBA(this Color color, float rgba)
        {
            return new Color(color.r + rgba, color.g + rgba, color.b + rgba, color.a + rgba);
        }
    }
}

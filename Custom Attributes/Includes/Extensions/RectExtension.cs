using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rito.CustomAttributes
{
    // 2020. 05. 19. 최초 작성

    /// <summary> 
    /// <para/> 날짜 : 2020-05-19 PM 9:12:01
    /// <para/> 설명 : Rect를 쉽게 변경할 수 있게 해주는 확장
    /// <para/> 
    /// </summary>
    public static class RectExtension
    {
        #region 내부 값 변경

        /// <summary>
        /// <para/> width 변경한 Rect 생성
        /// </summary>
        public static Rect Ex_SetWidth(this Rect @this, in float newWidth)
        {
            return new Rect(@this.x, @this.y, newWidth, @this.height);
        }

        /// <summary>
        /// <para/> height 변경한 Rect 생성
        /// </summary>
        public static Rect Ex_SetHeight(this Rect @this, in float newHeight)
        {
            return new Rect(@this.x, @this.y, @this.width, newHeight);
        }

        /// <summary>
        /// <para/> width, height 변경한 Rect 생성
        /// </summary>
        public static Rect Ex_SetWidthHeight(this Rect @this, in float newWidth, in float newHeight)
        {
            return new Rect(@this.x, @this.y, newWidth, newHeight);
        }

        /// <summary>
        /// <para/> 각각 값에 배수 곱해준 Rect 생성
        /// </summary>
        public static Rect Ex_Multiply(this Rect @this, in float xFactor = 1f, in float yFactor = 1f,
            in float widthFactor = 1f, in float heightFactor = 1f)
        {
            return new Rect(
                @this.x * xFactor,
                @this.y * yFactor,
                @this.width * widthFactor,
                @this.height * heightFactor);
        }

        #endregion // ==========================================================

        #region Height 1/2, 1/3, 2/3

        /// <summary>
        /// <para/> 높이가 절반인, 기존 Rect의 위쪽 절반 Rect 생성
        /// </summary>
        public static Rect Ex_UpHalf(this Rect @this)
        {
            return new Rect(
                @this.x,
                @this.y,
                @this.width,
                @this.height * 0.5f);
        }

        /// <summary>
        /// <para/> 높이가 절반인, 기존 Rect의 아래쪽 절반 Rect 생성
        /// </summary>
        public static Rect Ex_DownHalf(this Rect @this)
        {
            return new Rect(
                @this.x,
                @this.y + @this.height * 0.5f,
                @this.width,
                @this.height * 0.5f);
        }

        /// <summary>
        /// <para/> 높이가 1/3인, 기존 Rect의 위쪽 Rect 생성
        /// </summary>
        public static Rect Ex_UpThird(this Rect @this)
        {
            return new Rect(
                @this.x,
                @this.y,
                @this.width,
                @this.height / 3f);
        }

        /// <summary>
        /// <para/> 높이가 1/3인, 기존 Rect의 중앙 Rect 생성
        /// </summary>
        public static Rect Ex_MiddleThird(this Rect @this)
        {
            return new Rect(
                @this.x,
                @this.y + (@this.height / 3f),
                @this.width,
                @this.height / 3f);
        }

        /// <summary>
        /// <para/> 높이가 1/3인, 기존 Rect의 아래쪽 Rect 생성
        /// </summary>
        public static Rect Ex_DownThird(this Rect @this)
        {
            return new Rect(
                @this.x,
                @this.y + (@this.height * 2f / 3f),
                @this.width,
                @this.height / 3f);
        }



        /// <summary>
        /// <para/> 높이가 2/3인, 기존 Rect의 위쪽 Rect 생성
        /// </summary>
        public static Rect Ex_UpTwoThird(this Rect @this)
        {
            return new Rect(
                @this.x,
                @this.y,
                @this.width,
                @this.height * 2f / 3f);
        }

        /// <summary>
        /// <para/> 높이가 2/3인, 기존 Rect의 아래쪽 Rect 생성
        /// </summary>
        public static Rect Ex_DownTwoThird(this Rect @this)
        {
            return new Rect(
                @this.x,
                @this.y + @this.height * 2f / 3f,
                @this.width,
                @this.height * 2f / 3f);
        }

        #endregion // ==========================================================

        #region Height 배수

        /// <summary>
        /// <para/> 기존의 Rect 높이를 배수로 곱해준 Rect 생성
        /// </summary>
        public static Rect Ex_ChangeHeight(this Rect @this, in float heightFactor = 1f)
        {
            return new Rect(
                @this.x,
                @this.y,
                @this.width,
                @this.height * heightFactor);
        }

        /// <summary>
        /// <para/> 기존의 Rect보다 높이가 두 배인 Rect 생성
        /// </summary>
        public static Rect Ex_DoubleHeight(this Rect @this)
        {
            return new Rect(
                @this.x,
                @this.y,
                @this.width,
                @this.height * 2f);
        }

        /// <summary>
        /// <para/> 기존의 Rect보다 높이가 세 배인 Rect 생성
        /// </summary>
        public static Rect Ex_TripleHeight(this Rect @this)
        {
            return new Rect(
                @this.x,
                @this.y,
                @this.width,
                @this.height * 3f);
        }

        #endregion // ==========================================================

        #region 여백

        /// <summary>
        /// <para/> 기존 Rect를 잘라내어, 축소된 rect 생성
        /// <para/> * 결과 Rect는 기본 Rect의 중심 방향으로 잘린다.
        /// </summary>
        public static Rect Ex_Cut(this Rect @this,
            in float up = 0f, in float down = 0f, in float left = 0f, in float right = 0f)
        {
            return new Rect(
                @this.x + left,
                @this.y + up,
                @this.width - left - right,
                @this.height - up - down);
        }

        #endregion // ==========================================================
    }
}

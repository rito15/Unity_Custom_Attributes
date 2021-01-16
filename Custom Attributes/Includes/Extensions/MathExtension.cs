using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rito.CustomAttributes
{
    public static class MathExtension
    {
        #region ClampRef

        /// <summary>
        /// 변수의 최소, 최댓값 제한
        /// <para/> * 변수의 값을 실제로 변경시킴(ref)
        /// </summary>
        public static int Ex_ClampRef(ref this int value, in int min, in int max)
        {
            if (value < min) value = min;
            if (value > max) value = max;
            return value;
        }

        /// <summary>
        /// 변수의 최소, 최댓값 제한
        /// <para/> * 변수의 값을 실제로 변경시킴(ref)
        /// </summary>
        public static float Ex_ClampRef(ref this float value, in float min, in float max)
        {
            if (value < min) value = min;
            if (value > max) value = max;
            return value;
        }

        /// <summary>
        /// 변수의 최소, 최댓값 제한
        /// <para/> * 변수의 값을 실제로 변경시킴(ref)
        /// </summary>
        public static double Ex_ClampRef(ref this double value, in double min, in double max)
        {
            if (value < min) value = min;
            if (value > max) value = max;
            return value;
        }

        #endregion // ==========================================================

        #region ClampMinRef

        /// <summary>
        /// 변수의 최솟값 제한
        /// <para/> * 변수의 값을 실제로 변경시킴(ref)
        /// </summary>
        public static int Ex_ClampMinRef(ref this int value, in int min)
        {
            if (value < min) value = min;
            return value;
        }

        /// <summary>
        /// 변수의 최솟값 제한
        /// <para/> * 변수의 값을 실제로 변경시킴(ref)
        /// </summary>
        public static float Ex_ClampMinRef(ref this float value, in float min)
        {
            if (value < min) value = min;
            return value;
        }

        /// <summary>
        /// 변수의 최솟값 제한
        /// <para/> * 변수의 값을 실제로 변경시킴(ref)
        /// </summary>
        public static double Ex_ClampMinRef(ref this double value, in double min)
        {
            if (value < min) value = min;
            return value;
        }

        #endregion // ==========================================================

        #region ClampMaxRef

        /// <summary>
        /// 변수의 최댓값 제한
        /// <para/> * 변수의 값을 실제로 변경시킴(ref)
        /// </summary>
        public static int Ex_ClampMaxRef(ref this int value, in int max)
        {
            if (value > max) value = max;
            return value;
        }

        /// <summary>
        /// 변수의 최댓값 제한
        /// <para/> * 변수의 값을 실제로 변경시킴(ref)
        /// </summary>
        public static float Ex_ClampMaxRef(ref this float value, in float max)
        {
            if (value > max) value = max;
            return value;
        }

        /// <summary>
        /// 변수의 최댓값 제한
        /// <para/> * 변수의 값을 실제로 변경시킴(ref)
        /// </summary>
        public static double Ex_ClampMaxRef(ref this double value, in double max)
        {
            if (value > max) value = max;
            return value;
        }

        #endregion // ==========================================================

        #region Clamp

        /// <summary>
        /// 변수의 최소, 최댓값 제한
        /// </summary>
        public static int Ex_Clamp(this int value, in int min, in int max)
        {
            if (value < min) value = min;
            if (value > max) value = max;
            return value;
        }

        /// <summary>
        /// 변수의 최소, 최댓값 제한
        /// </summary>
        public static float Ex_Clamp(this float value, in float min, in float max)
        {
            if (value < min) value = min;
            if (value > max) value = max;
            return value;
        }

        /// <summary>
        /// 변수의 최소, 최댓값 제한
        /// </summary>
        public static double Ex_Clamp(this double value, in double min, in double max)
        {
            if (value < min) value = min;
            if (value > max) value = max;
            return value;
        }

        #endregion // ==========================================================

        #region ClampMin

        /// <summary>
        /// 변수의 최솟값 제한
        /// </summary>
        public static int Ex_ClampMin(this int value, in int min)
        {
            if (value < min) value = min;
            return value;
        }

        /// <summary>
        /// 변수의 최솟값 제한
        /// </summary>
        public static float Ex_ClampMin(this float value, in float min)
        {
            if (value < min) value = min;
            return value;
        }

        /// <summary>
        /// 변수의 최솟값 제한
        /// </summary>
        public static double Ex_ClampMin(this double value, in double min)
        {
            if (value < min) value = min;
            return value;
        }

        #endregion // ==========================================================

        #region ClampMax

        /// <summary>
        /// 변수의 최댓값 제한
        /// </summary>
        public static int Ex_ClampMax(this int value, in int max)
        {
            if (value > max) value = max;
            return value;
        }

        /// <summary>
        /// 변수의 최댓값 제한
        /// </summary>
        public static float Ex_ClampMax(this float value, in float max)
        {
            if (value > max) value = max;
            return value;
        }

        /// <summary>
        /// 변수의 최댓값 제한
        /// </summary>
        public static double Ex_ClampMax(this double value, in double max)
        {
            if (value > max) value = max;
            return value;
        }

        #endregion // ==========================================================

        #region InRange

        /// <summary>
        /// 변수의 값이 닫힌 범위 내에 있는지 검사
        /// </summary>
        public static bool Ex_InRange(this in int value, in int min, in int max)
        {
            return min <= value && value <= max;
        }

        /// <summary>
        /// 변수의 값이 닫힌 범위 내에 있는지 검사
        /// </summary>
        public static bool Ex_InRange(this in float value, in float min, in float max)
        {
            return min <= value && value <= max;
        }

        /// <summary>
        /// 변수의 값이 닫힌 범위 내에 있는지 검사
        /// </summary>
        public static bool Ex_InRange(this in double value, in double min, in double max)
        {
            return min <= value && value <= max;
        }

        #endregion // ==========================================================

        #region Pow

        /// <summary>
        /// n제곱 결과 리턴
        /// </summary>
        public static int Ex_Pow(in this int value, in int n)
        {
            int result = value;
            for (int i = 1; i < n; i++)
                result *= value;
            return result;
        }

        /// <summary>
        /// n제곱 결과 리턴
        /// </summary>
        public static float Ex_Pow(in this float value, in int n)
        {
            float result = value;
            for (int i = 1; i < n; i++)
                result *= value;
            return result;
        }

        /// <summary>
        /// n제곱 결과 리턴
        /// </summary>
        public static double Ex_Pow(in this double value, in int n)
        {
            double result = value;
            for (int i = 1; i < n; i++)
                result *= value;
            return result;
        }

        #endregion // ==========================================================

        #region Digitalize

        /// <summary>
        /// 0, 1 값으로 디지털화하여 리턴
        /// </summary>
        public static int Ex_Digitalize(in this int value)
        {
            return value == 0 ? 0 : 1;
        }

        /// <summary>
        /// 0, 1 값으로 디지털화하여 리턴
        /// </summary>
        public static float Ex_Digitalize(in this float value)
        {
            return value == 0f ? 0f : 1f;
        }

        /// <summary>
        /// 0, 1 값으로 디지털화하여 리턴
        /// </summary>
        public static double Ex_Digitalize(in this double value)
        {
            return value == 0.0 ? 0.0 : 1.0;
        }


        /// <summary>
        /// -1, 0, 1 값으로 디지털화하여 리턴
        /// </summary>
        public static int Ex_SignedDigitalize(in this int value)
        {
            if (value < 0) return -1;
            if (value > 0) return 1;
            return 0;
        }

        /// <summary>
        /// -1, 0, 1 값으로 디지털화하여 리턴
        /// </summary>
        public static float Ex_SignedDigitalize(in this float value)
        {
            if (value < 0f) return -1f;
            if (value > 0f) return 1f;
            return 0;
        }

        /// <summary>
        /// -1, 0, 1 값으로 디지털화하여 리턴
        /// </summary>
        public static double Ex_SignedDigitalize(in this double value)
        {
            if (value < 0.0) return -1.0;
            if (value > 0.0) return 1.0;
            return 0.0;
        }

        #endregion // ==========================================================
    }
}

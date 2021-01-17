using UnityEngine;

namespace Rito.CustomAttributes
{
    /// <summary> 
    /// 2020. 05. 01
    /// <para/> 색상 보관
    /// <para/> 
    /// </summary>
    public static class Colors
    {
        public static readonly Color Gold        = new Color(1.00f, 0.80f, 0.00f);
        public static readonly Color Orange      = new Color(1.00f, 0.50f, 0.00f);
        public static readonly Color Pink        = new Color(1.00f, 0.00f, 1.00f);
        public static readonly Color Brown       = new Color(0.50f, 0.25f, 0.00f);
        public static readonly Color Violet      = new Color(0.50f, 0.00f, 1.00f);
        public static readonly Color Lime        = new Color(0.75f, 1.00f, 0.00f);
        public static readonly Color Mint        = new Color(0.00f, 1.00f, 0.50f);
        public static readonly Color Cyan        = new Color(0.00f, 1.00f, 1.00f);
        public static readonly Color Sky         = new Color(0.00f, 1.00f, 1.00f);

        public static readonly Color LightRed    = new Color(1.00f, 0.50f, 0.50f);
        public static readonly Color LightBlue   = new Color(0.50f, 0.50f, 1.00f);
        public static readonly Color LightGreen  = new Color(0.50f, 1.00f, 0.50f);

        public static readonly Color LightYellow = new Color(1.00f, 1.00f, 0.75f);
        public static readonly Color LightOrange = new Color(1.00f, 0.75f, 0.50f);
        public static readonly Color LightPink   = new Color(1.00f, 0.50f, 1.00f);
        public static readonly Color LightBrown  = new Color(0.75f, 0.50f, 0.25f);
        public static readonly Color LightViolet = new Color(0.75f, 0.50f, 1.00f);
        public static readonly Color LightMint   = new Color(0.50f, 1.00f, 0.75f);
        public static readonly Color LightSky    = new Color(0.50f, 1.00f, 1.00f);
        public static readonly Color LightBlack  = new Color(0.10f, 0.10f, 0.10f);

        public static readonly Color WhitePink   = new Color(1.00f, 0.75f, 1.00f);

        public static readonly Color DarkRed     = new Color(0.50f, 0.00f, 0.00f);
        public static readonly Color DarkGreen   = new Color(0.00f, 0.50f, 0.00f);
        public static readonly Color DarkBlue    = new Color(0.00f, 0.00f, 0.50f);

        public static readonly Color DarkBrown   = new Color(0.25f, 0.12f, 0.00f);
        public static readonly Color DarkMint    = new Color(0.00f, 0.75f, 0.50f);
        public static readonly Color DarkGray    = new Color(0.20f, 0.20f, 0.20f);

        public static Color ChangeAlpha(in Color color, in float alpha)
        {
            return new Color(color.r, color.g, color.b, alpha);
        }

        public static Color Random(in float alpha = 1f)
        {
            return new Color(
                UnityEngine.Random.Range(0f, 1f),
                UnityEngine.Random.Range(0f, 1f),
                UnityEngine.Random.Range(0f, 1f),
                alpha);
        }

        public static Color RandomHue(in float alpha = 1f)
        {
            Color hsv = Color.HSVToRGB(
                UnityEngine.Random.Range(0f, 1f), 1f, 1f);

            return new Color(hsv.r, hsv.g, hsv.b, alpha);
        }
    }
}

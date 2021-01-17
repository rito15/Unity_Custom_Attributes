using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rito.CustomAttributes
{
    /// <summary> 
    /// <para/> 날짜 : 2020-05-16 AM 12:31:13
    /// <para/> 설명 : EColor -> Color 변환
    /// <para/> 
    /// </summary>
    public static class EColorConverter
    {
        public static Color Convert(EColor eColor)
        {
            switch (eColor)
            {
                default:
                case EColor.None:
                    return Color.black;

                case EColor.Rainbow:
                    rainbow.MoveNext();
                    return rainbow.Current;

                case EColor.Random:
                    return new Color(
                        Random.Range(0f, 1f),
                        Random.Range(0f, 1f),
                        Random.Range(0f, 1f));

                case EColor.White: return Color.white;
                case EColor.Black: return Color.black;
                case EColor.Gray: return Color.gray;

                case EColor.Red: return Color.red;
                case EColor.Blue: return Color.blue;
                case EColor.Green: return Color.green;
                case EColor.Yellow: return Color.yellow;

                case EColor.Gold: return Colors.Gold;
                case EColor.Orange: return Colors.Orange;
                case EColor.Pink: return Colors.Pink;
                case EColor.Brown: return Colors.Brown;
                case EColor.Violet: return Colors.Violet;
                case EColor.Lime: return Colors.Lime;
                case EColor.Mint: return Colors.Mint;
                case EColor.Cyan: return Colors.Cyan;
                case EColor.Sky: return Colors.Sky;

                case EColor.LightRed: return Colors.LightRed;
                case EColor.LightBlue: return Colors.LightBlue;
                case EColor.LightGreen: return Colors.LightGreen;
                case EColor.LightYellow: return Colors.LightYellow;

                case EColor.LightOrange: return Colors.LightOrange;
                case EColor.LightPink: return Colors.LightPink;
                case EColor.LightBrown: return Colors.LightBrown;
                case EColor.LightViolet: return Colors.LightViolet;
                case EColor.LightMint: return Colors.LightMint;
                case EColor.LightSky: return Colors.LightSky;
                case EColor.LightBlack: return Colors.LightBlack;

                case EColor.WhitePink: return Colors.WhitePink;

                case EColor.DarkRed: return Colors.DarkRed;
                case EColor.DarkGreen: return Colors.DarkGreen;
                case EColor.DarkBlue: return Colors.DarkBlue;

                case EColor.DarkBrown: return Colors.DarkBrown;
                case EColor.DarkMint: return Colors.DarkMint;
                case EColor.DarkGray: return Colors.DarkGray;
            }
        }

        private static IEnumerator<Color> rainbow = GetRainbow();
        private static IEnumerator<Color> GetRainbow()
        {
            float f = 0.00f;

            while (true)
            {
                yield return Color.HSVToRGB(f, 1, 1);

                f += 0.01f;
                if (f >= 1f) f = 0f;
            }
        }
    }

    public enum EColor
    {
        /// <summary> Black </summary>
        None,
        Rainbow,
        Random,

        White,
        Black,
        Gray,

        Red,
        Blue,
        Green,

        Yellow,
        Gold,
        Orange,
        Pink,
        Brown,
        Violet,
        Lime,
        Mint,
        Cyan,
        Sky,

        LightRed,
        LightBlue,
        LightGreen,
        LightYellow,

        LightOrange,
        LightPink,
        LightBrown,
        LightViolet,
        LightMint,
        LightSky,
        LightBlack,

        WhitePink,

        DarkRed,
        DarkGreen,
        DarkBlue,

        DarkBrown,
        DarkMint,
        DarkGray
    }
}

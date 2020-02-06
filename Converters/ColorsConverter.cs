using System;
using AvaColors = Avalonia.Media.Colors;
using AvaColor = Avalonia.Media.Color;

namespace AlienJust.Support.Avalonia.Converters
{
    static class ColorsConverter
    {        
        public static AvaColor Convert(Colors color)
        {
            switch (color)
            {
                case Colors.Red:
                    return AvaColors.Red;
                case Colors.Blue:
                    return AvaColors.Blue;
                case Colors.RoyalBlue:
                    return AvaColors.RoyalBlue;
                case Colors.DeepSkyBlue:
                    return AvaColors.DeepSkyBlue;
                case Colors.LightSkyBlue:
                    return AvaColors.LightSkyBlue;
                case Colors.DodgerBlue:
                    return AvaColors.DodgerBlue;
                case Colors.SkyBlue:
                    return AvaColors.SkyBlue;
                case Colors.SteelBlue:
                    return AvaColors.SteelBlue;
                case Colors.CornflowerBlue:
                    return AvaColors.CornflowerBlue;
                case Colors.LightBlue:
                    return AvaColors.LightBlue;

                case Colors.Green:
                    return AvaColors.Green;

                case Colors.Black:
                    return AvaColors.Black;
                case Colors.Transparent:
                    return AvaColors.Transparent;
                case Colors.White:
                    return AvaColors.White;

                case Colors.Orange:
                    return AvaColors.Orange;
                case Colors.OrangeRed:
                    return AvaColors.OrangeRed;
                case Colors.Firebrick:
                    return AvaColors.Firebrick;

                case Colors.Gray:
                    return AvaColors.Gray;
                case Colors.DarkGray:
                    return AvaColors.DarkGray;
                case Colors.LightGray:
                    return AvaColors.LightGray;

                case Colors.Lime:
                    return AvaColors.Lime;
                case Colors.LimeGreen:
                    return AvaColors.LimeGreen;
                case Colors.YellowGreen:
                    return AvaColors.YellowGreen;
                case Colors.Yellow:
                    return AvaColors.Yellow;

                case Colors.PaleVioletRed:
                    return AvaColors.PaleVioletRed;
                case Colors.IndianRed:
                    return AvaColors.IndianRed;

                case Colors.Magenta:
                    return AvaColors.Magenta;
                case Colors.Indigo:
                    return AvaColors.Indigo;
                case Colors.BlueViolet:
                    return AvaColors.BlueViolet;

                default:
                    throw new ArgumentOutOfRangeException(nameof(color));
            }
        }
    }
}
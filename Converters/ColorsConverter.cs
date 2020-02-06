namespace AlienJust.Support.Wpf.Converters
{
    static class ColorsConverter
    {
        public static Avalonia.Media.Color Convert(Colors color)
        {
            switch (color)
            {
                case Colors.Red:
                    return Avalonia.Media.Colors.Red;
                case Colors.Blue:
                    return Avalonia.Media.Colors.Blue;
                case Colors.RoyalBlue:
                    return Avalonia.Media.Colors.RoyalBlue;
                case Colors.DeepSkyBlue:
                    return Avalonia.Media.Colors.DeepSkyBlue;
                case Colors.LightSkyBlue:
                    return Avalonia.Media.Colors.LightSkyBlue;
                case Colors.DodgerBlue:
                    return Avalonia.Media.Colors.DodgerBlue;
                case Colors.SkyBlue:
                    return Avalonia.Media.Colors.SkyBlue;
                case Colors.SteelBlue:
                    return Avalonia.Media.Colors.SteelBlue;
                case Colors.CornflowerBlue:
                    return Avalonia.Media.Colors.CornflowerBlue;
                case Colors.LightBlue:
                    return Avalonia.Media.Colors.LightBlue;

                case Colors.Green:
                    return Avalonia.Media.Colors.Green;

                case Colors.Black:
                    return Avalonia.Media.Colors.Black;
                case Colors.Transparent:
                    return Avalonia.Media.Colors.Transparent;
                case Colors.White:
                    return Avalonia.Media.Colors.White;

                case Colors.Orange:
                    return Avalonia.Media.Colors.Orange;
                case Colors.OrangeRed:
                    return Avalonia.Media.Colors.OrangeRed;
                case Colors.Firebrick:
                    return Avalonia.Media.Colors.Firebrick;

                case Colors.Gray:
                    return Avalonia.Media.Colors.Gray;
                case Colors.DarkGray:
                    return Avalonia.Media.Colors.DarkGray;
                case Colors.LightGray:
                    return Avalonia.Media.Colors.LightGray;

                case Colors.Lime:
                    return Avalonia.Media.Colors.Lime;
                case Colors.LimeGreen:
                    return Avalonia.Media.Colors.LimeGreen;
                case Colors.YellowGreen:
                    return Avalonia.Media.Colors.YellowGreen;
                case Colors.Yellow:
                    return Avalonia.Media.Colors.Yellow;

                case Colors.PaleVioletRed:
                    return Avalonia.Media.Colors.PaleVioletRed;
                case Colors.IndianRed:
                    return Avalonia.Media.Colors.IndianRed;

                case Colors.Magenta:
                    return Avalonia.Media.Colors.Magenta;
                case Colors.Indigo:
                    return Avalonia.Media.Colors.Indigo;
                case Colors.BlueViolet:
                    return Avalonia.Media.Colors.BlueViolet;

                default:
                    throw new ArgumentOutOfRangeException(nameof(color));
            }
        }
    }
}
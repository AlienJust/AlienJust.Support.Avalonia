using System.Windows;
using Avalonia.Controls;
using Avalonia.Media;

namespace AlienJust.Support.Avalonia
{
    public class DpiDecorator : Decorator
    {
        public DpiDecorator()
        {
            Loaded += (s, e) =>
            {
                var presentationSource = PresentationSource.FromVisual(this);
                if (presentationSource?.CompositionTarget != null)
                {
                    Matrix m = presentationSource.CompositionTarget.TransformToDevice;
                    ScaleTransform dpiTransform = new ScaleTransform(1 / m.M11, 1 / m.M22);
                    if (dpiTransform.CanFreeze)
                        dpiTransform.Freeze();
                    LayoutTransform = dpiTransform;
                }
            };
        }
    }
}
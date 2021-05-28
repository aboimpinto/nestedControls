using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;

namespace nestedControls.Controls
{
    public class InnerControl : ContentControl
    {
        public static readonly StyledProperty<IBrush> BackgroundColorProperty =
            AvaloniaProperty.Register<InnerControl, IBrush>(nameof(BackgroundColor));

        public IBrush BackgroundColor
        {
            get => GetValue(BackgroundColorProperty);
            set => SetValue(BackgroundColorProperty, value);
        }
    }
}

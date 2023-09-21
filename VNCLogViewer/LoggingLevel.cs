using System.Windows;
using System.Windows.Media;

using VNC.Core.Mvvm;

namespace JSONConsoleApp.VNCLogViewer
{
    public class LoggingLevel : INPCBase
    {
        private Brush _brush;
        private string _label;
        public string Label
        {
            get => _label;
            set
            {
                if (_label == value)
                {
                    return;
                }

                _label = value;
                OnPropertyChanged();
            }
        }

        //private Color _labelColor = Color.Black;
        private System.Drawing.Color _labelColor;
        public System.Drawing.Color LabelColor
        {
            get => _labelColor;
            set
            {
                if (_labelColor == value)
                {
                    return;
                }

                _labelColor = value;
                OnPropertyChanged();
            }
        }

        //private Color _color = Color.FromArgb(200, 200, 200);
        private System.Drawing.Color _color;
        public System.Drawing.Color Color
        {
            get => _color;
            set
            {
                if (_color == value)
                {
                    return;
                }

                _color = value;
                OnPropertyChanged();
            }
        }


        public Brush Brush
        {
            get => _brush;
            set
            {
                if (_brush == value)
                    return;
                _brush = value;
                OnPropertyChanged();
            }
        }


        private bool _isChecked = true;
        public bool IsChecked
        {
            get => _isChecked;
            set
            {
                if (_isChecked == value)
                {
                    return;
                }

                _isChecked = value;
                OnPropertyChanged();
            }
        }

        private string _toolTip;
        public string ToolTip
        {
            get => _toolTip;
            set
            {
                if (_toolTip == value)
                {
                    return;
                }

                _toolTip = value;
                OnPropertyChanged();
            }
        }

        private Visibility _visibility = Visibility.Visible;
        public Visibility Visibility
        {
            get => _visibility;
            set
            {
                if (_visibility == value)
                {
                    return;
                }

                _visibility = value;
                OnPropertyChanged();
            }
        }

    }
}

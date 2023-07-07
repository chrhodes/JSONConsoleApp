namespace JSONConsoleApp.jsonDeserializeClass
{

    public class LoggingUIConfig_JsonRoot
    {
        public string Name { get; set; }
        public Info00 Info00 { get; set; }
        public Info01 Info01 { get; set; }
        public Info02 Info02 { get; set; }
        public Info03 Info03 { get; set; }
        public Info04 Info04 { get; set; }
        public Debug00 Debug00 { get; set; }
        public Debug01 Debug01 { get; set; }
        public Debug02 Debug02 { get; set; }
        public Debug03 Debug03 { get; set; }
        public Debug04 Debug04 { get; set; }
        public Arch00 Arch00 { get; set; }
        public Arch01 Arch01 { get; set; }
        public Arch02 Arch02 { get; set; }
        public Arch03 Arch03 { get; set; }
        public Arch04 Arch04 { get; set; }
        public Arch05 Arch05 { get; set; }
        public Arch06 Arch06 { get; set; }
        public Arch07 Arch07 { get; set; }
        public Arch08 Arch08 { get; set; }
        public Arch09 Arch09 { get; set; }
        public Arch10 Arch10 { get; set; }
        public Arch11 Arch11 { get; set; }
        public Arch12 Arch12 { get; set; }
        public Arch13 Arch13 { get; set; }
        public Arch14 Arch14 { get; set; }
        public Arch15 Arch15 { get; set; }
        public Arch16 Arch16 { get; set; }
        public Arch17 Arch17 { get; set; }
        public Arch18 Arch18 { get; set; }
        public Arch19 Arch19 { get; set; }
        public Trace00 Trace00 { get; set; }
        public Trace01 Trace01 { get; set; }
        public Trace02 Trace02 { get; set; }
        public Trace03 Trace03 { get; set; }
        public Trace04 Trace04 { get; set; }
        public Trace05 Trace05 { get; set; }
        public Trace06 Trace06 { get; set; }
        public Trace07 Trace07 { get; set; }
        public Trace08 Trace08 { get; set; }
        public Trace09 Trace09 { get; set; }
        public Trace10 Trace10 { get; set; }
        public Trace11 Trace11 { get; set; }
        public Trace12 Trace12 { get; set; }
        public Trace13 Trace13 { get; set; }
        public Trace14 Trace14 { get; set; }
        public Trace15 Trace15 { get; set; }
        public Trace16 Trace16 { get; set; }
        public Trace17 Trace17 { get; set; }
        public Trace18 Trace18 { get; set; }
        public Trace19 Trace19 { get; set; }
        public Trace20 Trace20 { get; set; }
        public Trace21 Trace21 { get; set; }
        public Trace22 Trace22 { get; set; }
        public Trace23 Trace23 { get; set; }
        public Trace24 Trace24 { get; set; }
        public Trace25 Trace25 { get; set; }
        public Trace26 Trace26 { get; set; }
        public Trace27 Trace27 { get; set; }
        public Trace28 Trace28 { get; set; }
        public Trace29 Trace29 { get; set; }

        public LoggingUIConfig ConvertToLoggingUIConfig()
        {
            LoggingUIConfig loggingUIConfig = new LoggingUIConfig();

            loggingUIConfig.Name = Name;

            // HACK(crhodes)
            // Can brute force this by checking each property or can be clever and
            // Reflect on the class and only update the ones that are not null
            //
            // Here a a few hard coded ones

            if (Info00 is not null)
            {
                loggingUIConfig.Info00 = new LoggingLevel 
                    {
                    Label = Info00.Label,
                    ToolTip = Info00.ToolTip,
                    Color = ConvertToColor(Info00.Color),
                    LabelColor = ConvertToColor(Info00.LabelColor),
                    IsChecked = Info00.IsChecked,
                    Visibility = (System.Windows.Visibility)Info00.Visibility
                };
            }

            if (Arch00 is not null)
            {
                loggingUIConfig.Arch00 = new LoggingLevel
                {
                    Label = Arch00.Label,
                    ToolTip = Arch00.ToolTip,
                    Color = ConvertToColor(Arch00.Color),
                    LabelColor = ConvertToColor(Arch00.LabelColor),
                    IsChecked = Arch00.IsChecked,
                    Visibility = (System.Windows.Visibility)Arch00.Visibility
                };
            }

            if (Arch01 is not null)
            {
                loggingUIConfig.Arch01 = new LoggingLevel
                {
                    Label = Arch01.Label,
                    ToolTip = Arch01.ToolTip,
                    Color = ConvertToColor(Arch01.Color),
                    LabelColor = ConvertToColor(Arch01.LabelColor),
                    IsChecked = Arch01.IsChecked,
                    Visibility = (System.Windows.Visibility)Arch01.Visibility
                };
            }

            return loggingUIConfig;
        }

        private System.Drawing.Color ConvertToColor(ColorX colorX)
        {
            System.Drawing.Color color = System.Drawing.Color.FromArgb(colorX.A, colorX.R, colorX.G, colorX.B);

            return color;
        }
    }


    public class Info00
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Info01
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Info02
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Info03
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Info04
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }


    public class Debug00
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Debug01
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Debug02
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Debug03
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Debug04
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Arch00
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Arch01
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Arch02
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Arch03
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Arch04
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Arch05
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Arch06
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Arch07
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Arch08
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Arch09
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }


    public class Arch10
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Arch11
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Arch12
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Arch13
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Arch14
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Arch15
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Arch16
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Arch17
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Arch18
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Arch19
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }


    public class Trace00
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Trace01
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Trace02
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Trace03
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Trace04
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Trace05
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Trace06
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Trace07
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Trace08
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Trace09
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }


    public class Trace10
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Trace11
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Trace12
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Trace13
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Trace14
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Trace15
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Trace16
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Trace17
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Trace18
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Trace19
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Trace20
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Trace21
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Trace22
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Trace23
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Trace24
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Trace25
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Trace26
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Trace27
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Trace28
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

    public class Trace29
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }

}

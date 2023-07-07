using System;

namespace JSONConsoleApp.jsonDeserializeClass
{

    public class LoggingUIConfig_JsonRoot
    {
        public string Name { get; set; }
        public LoggingLevelX Info00 { get; set; }
        public LoggingLevelX Info01 { get; set; }
        public LoggingLevelX Info02 { get; set; }
        public LoggingLevelX Info03 { get; set; }
        public LoggingLevelX Info04 { get; set; }
        public LoggingLevelX Debug00 { get; set; }
        public LoggingLevelX Debug01 { get; set; }
        public LoggingLevelX Debug02 { get; set; }
        public LoggingLevelX Debug03 { get; set; }
        public LoggingLevelX Debug04 { get; set; }
        public LoggingLevelX Arch00 { get; set; }
        public LoggingLevelX Arch01 { get; set; }
        public LoggingLevelX Arch02 { get; set; }
        public LoggingLevelX Arch03 { get; set; }
        public LoggingLevelX Arch04 { get; set; }
        public LoggingLevelX Arch05 { get; set; }
        public LoggingLevelX Arch06 { get; set; }
        public LoggingLevelX Arch07 { get; set; }
        public LoggingLevelX Arch08 { get; set; }
        public LoggingLevelX Arch09 { get; set; }
        public LoggingLevelX Arch10 { get; set; }
        public LoggingLevelX Arch11 { get; set; }
        public LoggingLevelX Arch12 { get; set; }
        public LoggingLevelX Arch13 { get; set; }
        public LoggingLevelX Arch14 { get; set; }
        public LoggingLevelX Arch15 { get; set; }
        public LoggingLevelX Arch16 { get; set; }
        public LoggingLevelX Arch17 { get; set; }
        public LoggingLevelX Arch18 { get; set; }
        public LoggingLevelX Arch19 { get; set; }
        public LoggingLevelX Trace00 { get; set; }
        public LoggingLevelX Trace01 { get; set; }
        public LoggingLevelX Trace02 { get; set; }
        public LoggingLevelX Trace03 { get; set; }
        public LoggingLevelX Trace04 { get; set; }
        public LoggingLevelX Trace05 { get; set; }
        public LoggingLevelX Trace06 { get; set; }
        public LoggingLevelX Trace07 { get; set; }
        public LoggingLevelX Trace08 { get; set; }
        public LoggingLevelX Trace09 { get; set; }
        public LoggingLevelX Trace10 { get; set; }
        public LoggingLevelX Trace11 { get; set; }
        public LoggingLevelX Trace12 { get; set; }
        public LoggingLevelX Trace13 { get; set; }
        public LoggingLevelX Trace14 { get; set; }
        public LoggingLevelX Trace15 { get; set; }
        public LoggingLevelX Trace16 { get; set; }
        public LoggingLevelX Trace17 { get; set; }
        public LoggingLevelX Trace18 { get; set; }
        public LoggingLevelX Trace19 { get; set; }
        public LoggingLevelX Trace20 { get; set; }
        public LoggingLevelX Trace21 { get; set; }
        public LoggingLevelX Trace22 { get; set; }
        public LoggingLevelX Trace23 { get; set; }
        public LoggingLevelX Trace24 { get; set; }
        public LoggingLevelX Trace25 { get; set; }
        public LoggingLevelX Trace26 { get; set; }
        public LoggingLevelX Trace27 { get; set; }
        public LoggingLevelX Trace28 { get; set; }
        public LoggingLevelX Trace29 { get; set; }

        public LoggingUIConfig ConvertToLoggingUIConfig()
        {
            LoggingUIConfig loggingUIConfig = new LoggingUIConfig();

            loggingUIConfig.Name = Name;

            // HACK(crhodes)
            // Can brute force this by checking each property or can be clever and
            // Reflect on the class and only update the ones that are not null
            //
            // Here a a few hard coded ones

            if (Info00 is not null) loggingUIConfig.Info00 = ConvertToLoggingUIConfig(Info00);

            if (Info01 is not null) loggingUIConfig.Info01 = ConvertToLoggingUIConfig(Info01);

            if (Arch00 is not null) loggingUIConfig.Arch00 = ConvertToLoggingUIConfig(Arch00);

            if (Arch01 is not null) loggingUIConfig.Arch01 = ConvertToLoggingUIConfig(Arch01);

            //if (Arch00 is not null)
            //{
            //    loggingUIConfig.Arch00 = new LoggingLevel
            //    {
            //        Label = Arch00.Label,
            //        ToolTip = Arch00.ToolTip,
            //        Color = ConvertToColor(Arch00.Color),
            //        LabelColor = ConvertToColor(Arch00.LabelColor),
            //        IsChecked = Arch00.IsChecked,
            //        Visibility = (System.Windows.Visibility)Arch00.Visibility
            //    };
            //}

            //if (Arch01 is not null)
            //{
            //    loggingUIConfig.Arch01 = new LoggingLevel
            //    {
            //        Label = Arch01.Label,
            //        ToolTip = Arch01.ToolTip,
            //        Color = ConvertToColor(Arch01.Color),
            //        LabelColor = ConvertToColor(Arch01.LabelColor),
            //        IsChecked = Arch01.IsChecked,
            //        Visibility = (System.Windows.Visibility)Arch01.Visibility
            //    };
            //}

            return loggingUIConfig;
        }

        private LoggingLevel ConvertToLoggingUIConfig(LoggingLevelX loggingLevelX)
        {
            LoggingLevel loggingLevel = new LoggingLevel
            {
                Label = loggingLevelX.Label,
                ToolTip = loggingLevelX.ToolTip,
                Color = ConvertToColor(loggingLevelX.Color),
                LabelColor = ConvertToColor(loggingLevelX.LabelColor),
                IsChecked = loggingLevelX.IsChecked,
                Visibility = (System.Windows.Visibility)loggingLevelX.Visibility
            };

            return loggingLevel;
        }

        private System.Drawing.Color ConvertToColor(ColorX colorX)
        {
            System.Drawing.Color color = System.Drawing.Color.FromArgb(colorX.A, colorX.R, colorX.G, colorX.B);

            return color;
        }
    }

    public class LoggingLevelX
    {
        public string Label { get; set; }
        public ColorX LabelColor { get; set; }
        public ColorX Color { get; set; }
        public bool IsChecked { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
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

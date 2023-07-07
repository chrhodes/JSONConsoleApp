using System;
using System.Drawing;
using System.IO;
using System.Text.Json;

namespace JSONConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        ConvertObjectToJSON();
    }

    private static void ConvertObjectToJSON()
    {
        LoggingLevel ll1 = new LoggingLevel { Label = "Info01", Color = Color.FromArgb(30, 150, 255), ToolTip = "" };

        LoggingLevel ll2 = new LoggingLevel();

        string fileName = "ll1.json";
        string jsonString = JsonSerializer.Serialize(ll1);
        File.WriteAllText(fileName, jsonString);

        //Console.WriteLine(File.ReadAllText(fileName));

        fileName = "ll2.json";
        jsonString = JsonSerializer.Serialize(ll2);
        File.WriteAllText(fileName, jsonString);

        //Console.WriteLine(File.ReadAllText(fileName));

        LoggingUIConfig loggingUIConfig = new LoggingUIConfig();
        LoggingUIConfigDEFAULT loggingUIConfigDefault = new LoggingUIConfigDEFAULT();
        LoggingUIConfigEASE loggingUIConfigEASE = new LoggingUIConfigEASE();
        LoggingUIConfigMINSK loggingUIConfigMINSK = new LoggingUIConfigMINSK();
        LoggingUIConfigVNCARCH loggingUIConfigVNCARCH = new LoggingUIConfigVNCARCH();

        fileName = "loggingUIConfig.json";
        jsonString = JsonSerializer.Serialize(loggingUIConfig);
        File.WriteAllText(fileName, jsonString);

        fileName = "loggingUIConfigDefault.json";
        jsonString = JsonSerializer.Serialize(loggingUIConfigDefault);
        File.WriteAllText(fileName, jsonString);

        fileName = "loggingUIConfigEASE.json";
        jsonString = JsonSerializer.Serialize(loggingUIConfigEASE);
        File.WriteAllText(fileName, jsonString);

        fileName = "loggingUIConfigMINSK.json";
        jsonString = JsonSerializer.Serialize(loggingUIConfigMINSK);
        File.WriteAllText(fileName, jsonString);

        fileName = "loggingUIConfigVNCARCH.json";
        jsonString = JsonSerializer.Serialize(loggingUIConfigVNCARCH);
        File.WriteAllText(fileName, jsonString);


    }
}

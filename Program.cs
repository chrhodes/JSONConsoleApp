using System;
using System.Drawing;
using System.IO;
using System.Text.Json;
using JSONConsoleApp.jsonDeserializeClass;

namespace JSONConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        Console.WriteLine($"{Directory.GetCurrentDirectory()}");

        Directory.SetCurrentDirectory("..\\..\\..\\json");

        Console.WriteLine($"{Directory.GetCurrentDirectory()}");

        //ConvertObjectToJSON();
        ConvertJSONToObject();
    }

    private static void ConvertObjectToJSON()
    {
        LoggingLevel ll1 = new LoggingLevel { Label = "Info01", Color = Color.FromArgb(30, 150, 255), ToolTip = "" };

        LoggingLevel ll2 = new LoggingLevel();

        LoggingUIConfig loggingUIConfig = new LoggingUIConfig();
        LoggingUIConfigDEFAULT loggingUIConfigDefault = new LoggingUIConfigDEFAULT();
        LoggingUIConfigEASE loggingUIConfigEASE = new LoggingUIConfigEASE();
        LoggingUIConfigMINSK loggingUIConfigMINSK = new LoggingUIConfigMINSK();
        LoggingUIConfigVNCARCH loggingUIConfigVNCARCH = new LoggingUIConfigVNCARCH();

        var options = new JsonSerializerOptions { WriteIndented = true };

        string fileName = "ll1.json";
        string jsonString = JsonSerializer.Serialize(ll1, options);
        File.WriteAllText(fileName, jsonString);

        //Console.WriteLine(File.ReadAllText(fileName));

        fileName = "ll2.json";
        jsonString = JsonSerializer.Serialize(ll2, options);
        File.WriteAllText(fileName, jsonString);

        //Console.WriteLine(File.ReadAllText(fileName));



        fileName = "loggingUIConfig.json";
        jsonString = JsonSerializer.Serialize(loggingUIConfig, options);
        File.WriteAllText(fileName, jsonString);

        fileName = "loggingUIConfigDefault.json";
        jsonString = JsonSerializer.Serialize(loggingUIConfigDefault, options);
        File.WriteAllText(fileName, jsonString);

        fileName = "loggingUIConfigEASE.json";
        jsonString = JsonSerializer.Serialize(loggingUIConfigEASE, options);
        File.WriteAllText(fileName, jsonString);

        fileName = "loggingUIConfigMINSK.json";
        jsonString = JsonSerializer.Serialize(loggingUIConfigMINSK, options);
        File.WriteAllText(fileName, jsonString);

        fileName = "loggingUIConfigVNCARCH.json";
        jsonString = JsonSerializer.Serialize(loggingUIConfigVNCARCH, options);
        File.WriteAllText(fileName, jsonString);

    }

    private static void ConvertJSONToObject()
    {
        LoggingLevel? ll1;// = new LoggingLevel { Label = "Info01", Color = Color.FromArgb(30, 150, 255), ToolTip = "" };

        //LoggingLevel? ll2;// = new LoggingLevel();

        string fileName = "ll1.json";
        string jsonString = File.ReadAllText(fileName);
        
        //ll1 = JsonSerializer.Deserialize<LoggingLevel>(jsonString);
        LoggingLevel_JsonRoot? ll2 = JsonSerializer.Deserialize<LoggingLevel_JsonRoot>(jsonString);



        fileName = "loggingUIConfig.json";
        jsonString = File.ReadAllText(fileName);
        LoggingUIConfig_JsonRoot? loggingUIConfig_JsonRoot = JsonSerializer.Deserialize<LoggingUIConfig_JsonRoot>(jsonString);

        fileName = "loggingUIConfigVNCARCH.json";
        jsonString = File.ReadAllText(fileName);
        LoggingUIConfig_JsonRoot? loggingUIConfigVNCARCH = JsonSerializer.Deserialize<LoggingUIConfig_JsonRoot>(jsonString);

        fileName = "loggingUIConfigTEST.json";
        jsonString = File.ReadAllText(fileName);
        LoggingUIConfig_JsonRoot? loggingUIConfigTEST = JsonSerializer.Deserialize<LoggingUIConfig_JsonRoot>(jsonString);

        LoggingUIConfig loggingUIConfig;

        loggingUIConfig = loggingUIConfigTEST.ConvertToLoggingUIConfig();

        //Color foo = ll2.Color;

        //LoggingLevel ll3 = (LoggingLevel)ll2;


        //fileName = "ll2.json";
        //jsonString = JsonSerializer.Serialize(ll2);
        //File.WriteAllText(fileName, jsonString);

        ////Console.WriteLine(File.ReadAllText(fileName));

        //LoggingUIConfig loggingUIConfig = new LoggingUIConfig();
        //LoggingUIConfigDEFAULT loggingUIConfigDefault = new LoggingUIConfigDEFAULT();
        //LoggingUIConfigEASE loggingUIConfigEASE = new LoggingUIConfigEASE();
        //LoggingUIConfigMINSK loggingUIConfigMINSK = new LoggingUIConfigMINSK();
        //LoggingUIConfigVNCARCH loggingUIConfigVNCARCH = new LoggingUIConfigVNCARCH();

        //fileName = "loggingUIConfig.json";
        //jsonString = JsonSerializer.Serialize(loggingUIConfig);
        //File.WriteAllText(fileName, jsonString);

        //fileName = "loggingUIConfigDefault.json";
        //jsonString = JsonSerializer.Serialize(loggingUIConfigDefault);
        //File.WriteAllText(fileName, jsonString);

        //fileName = "loggingUIConfigEASE.json";
        //jsonString = JsonSerializer.Serialize(loggingUIConfigEASE);
        //File.WriteAllText(fileName, jsonString);

        //fileName = "loggingUIConfigMINSK.json";
        //jsonString = JsonSerializer.Serialize(loggingUIConfigMINSK);
        //File.WriteAllText(fileName, jsonString);

        //fileName = "loggingUIConfigVNCARCH.json";
        //jsonString = JsonSerializer.Serialize(loggingUIConfigVNCARCH);
        //File.WriteAllText(fileName, jsonString);
    }
}

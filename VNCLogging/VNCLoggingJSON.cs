using System;
using System.IO;
using System.Text.Json;

using JSONConsoleApp.VNCLogging;
using JSONConsoleApp.VNCPhidget;

namespace JSONConsoleApp
{
    public class VNCLoggingJSON
    {
        public VNCLoggingJSON(string jsonDirectory)
        {
            Console.WriteLine($"{Directory.GetCurrentDirectory()}");

            Directory.SetCurrentDirectory(jsonDirectory);

            Console.WriteLine($"{Directory.GetCurrentDirectory()}");
        }

        internal void ConvertObjectsToJSON()
        {
            JsonHelper.ConvertObject<VNCLoggingConfig>(new VNCLoggingConfig(), "vncloggingconfig.json");
        }

        internal void ConvertJSONToObject()
        {
            string fileName;
            string jsonString;

            fileName = "vncloggingconfig.json";
            jsonString = File.ReadAllText(fileName);

            VNCLoggingConfig? vncLogging = JsonSerializer.Deserialize<VNCLoggingConfig>(jsonString);
        }
    }
}

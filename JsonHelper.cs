using System;
using System.IO;
using System.Text.Json;

namespace JSONConsoleApp
{
    public class JsonHelper
    {
        public static void ConvertObject<T>(T type, string fileName)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };

            string jsonString = JsonSerializer.Serialize<T>(type, options);

            File.WriteAllText(fileName, jsonString);

            Console.WriteLine(File.ReadAllText(fileName));
        }
    }
}

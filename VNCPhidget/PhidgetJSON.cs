using System;
using System.IO;
using System.Text.Json;

using JSONConsoleApp.VNCPhidget;

namespace JSONConsoleApp
{
    public class PhidgetJSON
    {
        public PhidgetJSON(string jsonDirectory)
        {
            Console.WriteLine($"{Directory.GetCurrentDirectory()}");

            Directory.SetCurrentDirectory(jsonDirectory);

            Console.WriteLine($"{Directory.GetCurrentDirectory()}");
        }

        internal void ConvertObjectsToJSON()
        {
            JsonHelper.ConvertObject<Host>(new Host(), "host.json");
            JsonHelper.ConvertObject<InterfaceKit>(new InterfaceKit(), "interfacekit.json");
            JsonHelper.ConvertObject<Sensor>(new Sensor(), "sensor.json");
            JsonHelper.ConvertObject<PhidgetConfig>(new PhidgetConfig(), "phidgetconfig.json");

            JsonHelper.ConvertObject<AdvancedServoStep>(new AdvancedServoStep(), "advancedservostep.json");
            JsonHelper.ConvertObject<AdvancedServoPerformance>(new AdvancedServoPerformance(), "advancedservoperformance.json");
            JsonHelper.ConvertObject<AdvancedServoPerformanceConfig>(new AdvancedServoPerformanceConfig(), "advancedservoperformancesconfig.json");
        }

        internal void ConvertJSONToObject()
        {
            string fileName;
            string jsonString;

            fileName = "host.json";
            jsonString = File.ReadAllText(fileName);

            Host? host = JsonSerializer.Deserialize<Host>(jsonString);

            fileName = "interfacekit.json";
            jsonString = File.ReadAllText(fileName);

            InterfaceKit? interfaceKit = JsonSerializer.Deserialize<InterfaceKit>(jsonString);

            fileName = "sensor.json";
            jsonString = File.ReadAllText(fileName);

            Sensor? sensor = JsonSerializer.Deserialize<Sensor>(jsonString);
        }
    }
}

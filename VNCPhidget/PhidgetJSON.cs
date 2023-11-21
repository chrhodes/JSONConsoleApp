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
            JsonHelper.ConvertObject<HostConfig>(new HostConfig(), "hostconfig.json");
            JsonHelper.ConvertObject<PhidgetDevice>(new PhidgetDevice(), "phidgetdevice.json");

            JsonHelper.ConvertObject<PerformanceConfig>(new PerformanceConfig(), "performanceconfig.json");
            JsonHelper.ConvertObject<Performance>(new Performance(), "performance.json");
            JsonHelper.ConvertObject<PerformanceSequence>(new PerformanceSequence(), "performancesequence.json");

            JsonHelper.ConvertObject<AdvancedServo>(new AdvancedServo(), "advancedservo.json");
            JsonHelper.ConvertObject<AdvancedServoServoAction>(new AdvancedServoServoAction(), "advancedservoservoaction.json");
            JsonHelper.ConvertObject<AdvancedServoSequence>(new AdvancedServoSequence(), "advancedservosequence.json");
            JsonHelper.ConvertObject<AdvancedServoSequenceConfig>(new AdvancedServoSequenceConfig(), "advancedservosequenceconfig.json");


            JsonHelper.ConvertObject<InterfaceKit>(new InterfaceKit(), "interfacekit.json");
            JsonHelper.ConvertObject<InterfaceKitAction>(new InterfaceKitAction(), "interfacekitaction.json");
            JsonHelper.ConvertObject<InterfaceKitSequence>(new InterfaceKitSequence(), "interfacekitsequence.json");
            JsonHelper.ConvertObject<InterfaceKitSequenceConfig>(new InterfaceKitSequenceConfig(), "interfacekitsequenceconfig.json");

            JsonHelper.ConvertObject<Sensor>(new Sensor(), "sensor.json");


            JsonHelper.ConvertObject<Stepper>(new Stepper(), "stepper.json");
            JsonHelper.ConvertObject<StepperAction>(new StepperAction(), "stepperaction.json");
            JsonHelper.ConvertObject<StepperSequence>(new StepperSequence(), "steppersequence.json");
            JsonHelper.ConvertObject<StepperSequenceConfig>(new StepperSequenceConfig(), "steppersequenceconfig.json");

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

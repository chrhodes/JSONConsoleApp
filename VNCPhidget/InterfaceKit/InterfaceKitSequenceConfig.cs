
namespace JSONConsoleApp.VNCPhidget
{
    public class InterfaceKitSequenceConfig
    {
        InterfaceKitSequence[] InterfaceKitSequences = new[]
        {
            new InterfaceKitSequence
            {
                Host = new Host
                {
                    Name = "localhost",
                    IPAddress = "127.0.0.1",
                    Port = 5001,
                    InterfaceKits = new[]
                    {
                        new InterfaceKit
                        {
                            Name = "InterfaceKit 1",
                            SerialNumber = 46049,
                            Open = true
                        }
                    }
                },
                Name="SequenceIK 1",
                ContinueWith="",

                InterfaceKitActions = new[]
                {
                    new InterfaceKitAction { ServoIndex = 0, Acceleration = 5000, VelocityLimit = 200, Engaged = true }
                }
            },
 
        };
    }
}

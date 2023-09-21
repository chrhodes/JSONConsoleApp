using System;

namespace JSONConsoleApp.VNCPhidget
{
    public class Host
    {
        public string Name { get; set; } = "HOST NAME";
        public string IPAddress { get; set; } = "192.168.150.1";
        public int Port { get; set; } = 5001;
        public bool Enable { get; set; } = true;

        public InterfaceKit[] InterfaceKits { get; set; } = new[]
        { 
            new InterfaceKit { Name = "InterfaceKit 1", SerialNumber = "1234", Embedded = true, Enable = true },
            new InterfaceKit { Name = "InterfaceKit 2", SerialNumber = "5678", Embedded = false, Enable = false }
        };
    }
}


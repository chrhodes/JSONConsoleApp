using System;

namespace JSONConsoleApp.VNCPhidget
{
    public class InterfaceKit
    {
        public string Name { get; set; } = "INTERFACEKIT NAME";
        public Int32 SerialNumber { get; set; }
        public bool Open { get; set; } = false;
        public bool Embedded { get; set; } = false;
    }
}

using Phidgets;

using static Phidgets.Phidget;

namespace JSONConsoleApp.VNCPhidget
{
    public struct SerialHost
    {
        public string IPAddress;
        public int SerialNumber;
    }

    public class PhidgetDevice
    {
        public PhidgetDevice()
        {
        }

        public PhidgetDevice(string ipAddress, int port, PhidgetClass phidgetClass, int serialNumber)
        {
            IPAddress = ipAddress;
            Port = port;
            PhidgetClass = phidgetClass;
            SerialNumber = serialNumber;
        }

        public string IPAddress { get; set; } = "127.0.0.1";

        public int Port { get; set; } = 5001;

        public Phidget.PhidgetClass PhidgetClass { get; set; } = Phidget.PhidgetClass.NOTHING;

        public int SerialNumber { get; set; } = 0;
    }
}


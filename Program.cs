using System;
using System.IO;

namespace JSONConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        // NOTE(crhodes)
        // For VNCLogViewer

        //VNCLogViewerJSON explore = new VNCLogViewerJSON("..\\..\\..\\VNCLogViewer\\json");

        //explore.ConvertObjectsToJSON();

        //explore.ConvertJSONToObject();

        // NOTE(crhodes)
        // For VNCPhidget22

        PhidgetJSON explore = new PhidgetJSON("..\\..\\..\\VNCPhidget\\json");

        //explore.ConvertObjectsToJSON();

        //explore.ConvertJSONToObject();

        // NOTE(crhodes)
        // For VNCLogging

        //VNCLoggingJSON explore = new VNCLoggingJSON("..\\..\\..\\VNCLogging\\json");

        explore.ConvertObjectsToJSON();

        explore.ConvertJSONToObject();
    }
}

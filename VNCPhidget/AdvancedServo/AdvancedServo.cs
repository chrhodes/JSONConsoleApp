﻿namespace JSONConsoleApp.VNCPhidget
{
    public class AdvancedServo
    {
        public string Name { get; set; } = "ADVANCEDSERVO NAME";
        public int SerialNumber { get; set; } = 12345;
        // NOTE(crhodes)
        // How do we use Enable?  If just like open, remove
        //public bool? Enable { get; set; } = true;
        public bool Open { get; set; } = true;
        // NOTE(crhodes)
        // How is this used.  Seems just descriptive
        //public bool? Embedded { get; set; } = false;
    }
}

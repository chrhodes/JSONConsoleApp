using System;

namespace JSONConsoleApp
{
    public class AdvancedServoStep
    {
        public int ServoIndex { get; set; }

        public bool? Engaged { get; set; }
        public Double? Acceleration { get; set; }
        public Double? Velocity { get; set; }
        public double? TargetPosition { get; set; }
        public Int32 Duration { get; set; } = 1000; // ms
        public Int32 Loops { get; set; } = 1;       // 1 Loop
    }
}

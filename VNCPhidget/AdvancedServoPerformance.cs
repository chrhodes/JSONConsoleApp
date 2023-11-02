﻿namespace JSONConsoleApp
{

    public class AdvancedServoPerformance
    {
        public string Name { get; set; } = "PERFORMANCE NAME";
        public string Description { get; set; } = "PERFORMANCE DESCRIPTION";
        public string ContinueWith { get; set; } = "CONTINUE WITH PERFORMANCE NAME";

        public AdvancedServoStep[] AdvancedServoSteps { get; set; } = new[]
        {
            new AdvancedServoStep { ServoIndex = 0, Engaged = true, TargetPosition = 90, Duration=1000 },
            new AdvancedServoStep { ServoIndex = 0, Engaged = true, TargetPosition = 95, Duration=1000 },
            new AdvancedServoStep { ServoIndex = 0, Engaged = true, TargetPosition = 100, Duration=2000 },
            new AdvancedServoStep { ServoIndex = 0, Engaged = true, TargetPosition = 95, Duration=500 },
            new AdvancedServoStep { ServoIndex = 0, Engaged = true, TargetPosition = 90, Duration=500 }
        };
    }
}
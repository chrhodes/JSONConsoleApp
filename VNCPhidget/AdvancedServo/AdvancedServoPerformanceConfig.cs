using JSONConsoleApp.VNCPhidget;

namespace JSONConsoleApp
{
    public class AdvancedServoPerformanceConfig
    {
        public AdvancedServoSequence[] AdvancedServoPerformances { get; set; } = new[]
        {
            new AdvancedServoSequence
            {
                Name="PerformanceServo0",
                ContinueWith="PerformanceServo1",

                AdvancedServoServoActions = new[]
                {
                    new AdvancedServoServoAction { ServoIndex = 0, Engaged = true, TargetPosition = 90, Duration=1000 },
                    new AdvancedServoServoAction { ServoIndex = 0, Engaged = true, TargetPosition = 95, Duration=1000 },
                    new AdvancedServoServoAction { ServoIndex = 0, Engaged = true, TargetPosition = 100, Duration=2000 },
                    new AdvancedServoServoAction { ServoIndex = 0, Engaged = true, TargetPosition = 95, Duration=500 },
                    new AdvancedServoServoAction { ServoIndex = 0, Engaged = true, TargetPosition = 90, Duration=500 }
                }
            },
            new AdvancedServoSequence
            {
                Name="PerformanceServo1",
                ContinueWith="PerformanceServo2",

                AdvancedServoServoActions = new[]
                {
                    new AdvancedServoServoAction { ServoIndex = 1, Engaged = true, TargetPosition = 90, Duration=1000 },
                    new AdvancedServoServoAction { ServoIndex = 1, Engaged = true, TargetPosition = 95, Duration=1000 },
                    new AdvancedServoServoAction { ServoIndex = 1, Engaged = true, TargetPosition = 100, Duration=2000 },
                    new AdvancedServoServoAction { ServoIndex = 1, Engaged = true, TargetPosition = 95, Duration=500 },
                    new AdvancedServoServoAction { ServoIndex = 1, Engaged = true, TargetPosition = 90, Duration=500 }
                }
            },
            new AdvancedServoSequence
            {
                Name="PerformanceServo2",

                AdvancedServoServoActions = new[]
                {
                    new AdvancedServoServoAction { ServoIndex = 2, Engaged = true, TargetPosition = 90, Duration=1000 },
                    new AdvancedServoServoAction { ServoIndex = 2, Engaged = true, TargetPosition = 95, Duration=1000 },
                    new AdvancedServoServoAction { ServoIndex = 2, Engaged = true, TargetPosition = 100, Duration=2000 },
                    new AdvancedServoServoAction { ServoIndex = 2, Engaged = true, TargetPosition = 95, Duration=500 },
                    new AdvancedServoServoAction { ServoIndex = 2, Engaged = true, TargetPosition = 90, Duration=500 }
                }
            }
        };
    }
}

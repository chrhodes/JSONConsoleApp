using System;

using JSONConsoleApp.VNCPhidget;

namespace JSONConsoleApp
{
    public class AdvancedServoPerformance
    {
        public AdvancedServoSequence[] AdvancedServoSequence { get; set; } = new[] // AdvancedServoSequence[0];
        {
            new AdvancedServoSequence { Host = new Host(), Name="SequenceName", Description="", AdvancedServoServoActions = new AdvancedServoServoAction[0] },
            new AdvancedServoSequence { Host = new Host(), Name="SequenceName", Description="", AdvancedServoServoActions = new AdvancedServoServoAction[0] }
        };

    }
}

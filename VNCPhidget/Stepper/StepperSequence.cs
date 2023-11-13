﻿using System;

namespace JSONConsoleApp.VNCPhidget
{

    public class StepperSequence
    {
        public Host Host { get; set; }
            = new Host
            {
                Name = "localhost",
                IPAddress = "127.0.0.1",
                Port = 5001,
                InterfaceKits = new[]
                {
                    new InterfaceKit 
                    { 
                        Name = "Steper 1", 
                        SerialNumber = 99415,                         
                        Open = true
                    }
                }
            };

        /// <summary>
        /// Name of performance
        /// </summary>
        public string Name { get; set; } = "SEQUENCE NAME";

        /// <summary>
        /// Description of performance
        /// </summary>
        public string Description { get; set; } = "SEQUENCE DESCRIPTION";

        /// <summary>
        /// Number of loops of Performance
        /// </summary>
        public Int32 Loops { get; set; } = 1;

        /// <summary>
        /// Play ServoAction[] in Parallel or Sequential (false)
        /// </summary>
        public Boolean PlayInParallel { get; set; } = false;

        /// <summary>
        /// Name of performance to invoke at end of performance (optional)
        /// none, null, or empty string to stop
        /// </summary>
        public string? ContinueWith { get; set; } = "";

        /// <summary>
        /// Array of steps in performance
        /// </summary>
        public StepperAction[] StepperActions { get; set; } = new[] // StepperAction[0];
        {
            new StepperAction { ServoIndex = 0, Engaged = true, TargetPosition = 90, Duration=1000 },
            new StepperAction { ServoIndex = 0, Engaged = true, TargetPosition = 95, Duration=1000 },
            new StepperAction { ServoIndex = 0, Engaged = true, TargetPosition = 100, Duration = 2000 },
            new StepperAction { ServoIndex = 0, Engaged = true, TargetPosition = 95, Duration = 500 },
            new StepperAction { ServoIndex = 0, Engaged = true, TargetPosition = 90, Duration = 500 }
        };
    }
}

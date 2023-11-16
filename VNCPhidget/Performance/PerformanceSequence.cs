﻿using System;

namespace JSONConsoleApp.VNCPhidget
{
    public class PerformanceSequence
    {
        /// <summary>
        /// Name of Sequence
        /// </summary>
        public string Name { get; set; } = "SEQUENCE NAME";

        /// <summary>
        /// Type of Sequence {AS, IK, ST}
        /// Maybe make this enum
        /// </summary>
        public string SequenceType { get; set; }

        /// <summary>
        /// Number of loops of Sequence
        /// </summary>
        public Int32 Loops { get; set; } = 1;

        /// <summary>
        /// Close Phidget at end of sequence loops
        /// </summary>
        public Boolean ClosePhidget { get; set; } = false;
    }
}

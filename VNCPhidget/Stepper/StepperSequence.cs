namespace JSONConsoleApp.VNCPhidget
{
    public class StepperSequence : PhidgetSequenceBase
    {
        /// <summary>
        /// Array of Stepper actions in sequence
        /// </summary>
        public StepperAction[] Actions { get; set; }
    }
}

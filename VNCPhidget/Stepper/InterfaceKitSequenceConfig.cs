using JSONConsoleApp.VNCPhidget;

namespace JSONConsoleApp
{
    public class StepperSequenceConfig
    {
        StepperSequence[] StepperSequences = new[]
        {
            new StepperSequence
            {
                Host = new Host
                {
                    Name = "localhost",
                    IPAddress = "127.0.0.1",
                    Port = 5001,
                    Steppers = new[]
                    {
                        new Stepper
                        {
                            Name = "Stepper 1",
                            SerialNumber = 46049,
                            Open = true
                        }
                    }
                },
                Name="SequenceStepper 1",
                ContinueWith="",

                StepperActions = new[]
                {
                    new StepperAction { ServoIndex = 0, Acceleration = 5000, VelocityLimit = 200, Engaged = true }
                }
            },
 
        };
    }
}

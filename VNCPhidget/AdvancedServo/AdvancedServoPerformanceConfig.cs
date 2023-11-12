using JSONConsoleApp.VNCPhidget;

namespace JSONConsoleApp
{
    public class AdvancedServoPerformanceConfig
    {
        public AdvancedServoPerformance[] AdvancedServoPerformances { get; set;  } = new[]
        {
            new AdvancedServoPerformance
            {
                Name = "Performance0",
                Description = "Performance0 Description",
                Loops = 1,
                PlayInParallel = false,
                ContinueWith = "",

                AdvancedServoSequences = new[]
                {
                    new AdvancedServoSequence
                    {
                        Host = new Host
                        {
                            Name = "localhost",
                            IPAddress = "127.0.0.1",
                            Port = 5001,
                            AdvancedServos = new[]
                            {
                                new AdvancedServo
                                {
                                    Name = "AdvancedServo 1",
                                    SerialNumber = 99415,
                                    Open = true
                                }
                            }
                        },
                        Name="SequenceServo0",
                        ContinueWith="SequenceServo1",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 0, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                            new AdvancedServoServoAction { ServoIndex = 0, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 0, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 0, TargetPosition = 110 },
                            new AdvancedServoServoAction { ServoIndex = 0, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 0, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 0, Engaged = false },
                        }
                    },
                    new AdvancedServoSequence
                    {
                        Name="SequenceServo1",
                        ContinueWith="SequenceServo2",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 1, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                            new AdvancedServoServoAction { ServoIndex = 1, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 1, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 1, TargetPosition = 110 },
                            new AdvancedServoServoAction { ServoIndex = 1, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 1, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 1, Engaged = false },
                        }
                    },
                    new AdvancedServoSequence
                    {
                        Name="SequenceServo2",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 2, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                            new AdvancedServoServoAction { ServoIndex = 2, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 2, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 2, TargetPosition = 110 },
                            new AdvancedServoServoAction { ServoIndex = 2, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 2, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 2, Engaged = false },
                        }
                    }
                }
            },
            new AdvancedServoPerformance
            {
                Name = "Performance0B",
                Description = "Performance0B Description",
                Loops = 1,
                PlayInParallel = false,
                ContinueWith = "",

                AdvancedServoSequences = new[]
                {
                    new AdvancedServoSequence
                    {
                        Host = new Host
                        {
                            Name = "localhost",
                            IPAddress = "127.0.0.1",
                            Port = 5001,
                            AdvancedServos = new[]
                            {
                                new AdvancedServo
                                {
                                    Name = "AdvancedServo 1",
                                    SerialNumber = 99415,
                                    Open = true
                                }
                            }
                        },
                        Name="SequenceServo0",
                        ContinueWith="SequenceServo1",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 4, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                            new AdvancedServoServoAction { ServoIndex = 4, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 4, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 4, TargetPosition = 110 },
                            new AdvancedServoServoAction { ServoIndex = 4, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 4, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 4, Engaged = false },
                        }
                    },
                    new AdvancedServoSequence
                    {
                        Name="SequenceServo1",
                        ContinueWith="SequenceServo2",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 5, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                            new AdvancedServoServoAction { ServoIndex = 5, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 5, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 5, TargetPosition = 110 },
                            new AdvancedServoServoAction { ServoIndex = 5, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 5, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 5, Engaged = false },
                        }
                    },
                    new AdvancedServoSequence
                    {
                        Name="SequenceServo2",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 6, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                            new AdvancedServoServoAction { ServoIndex = 6, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 6, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 6, TargetPosition = 110 },
                            new AdvancedServoServoAction { ServoIndex = 6, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 6, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 6, Engaged = false },
                        }
                    }
                }
            },

            new AdvancedServoPerformance
            {
                Name = "Performance1",
                Description = "Performance1 Description",
                Loops = 1,
                PlayInParallel = false,
                ContinueWith = "",

                AdvancedServoSequences = new[]
                {
                    new AdvancedServoSequence
                    {
                        Host = new Host
                        {
                            Name = "psbc11",
                            IPAddress = "192.168.150.11",
                            Port = 5001,
                            AdvancedServos = new[]
                            {
                                new AdvancedServo
                                {
                                    Name = "AdvancedServo 1",
                                    SerialNumber = 99415,
                                    Open = true
                                }
                            }
                        },
                        Name="SequenceServo0",
                        ContinueWith="SequenceServo1",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 0, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                            new AdvancedServoServoAction { ServoIndex = 0, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 0, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 0, TargetPosition = 110 },
                            new AdvancedServoServoAction { ServoIndex = 0, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 0, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 0, Engaged = false },
                        }
                    },
                    new AdvancedServoSequence
                    {
                        Name="SequenceServo1",
                        ContinueWith="SequenceServo2",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 1, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                            new AdvancedServoServoAction { ServoIndex = 1, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 1, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 1, TargetPosition = 110 },
                            new AdvancedServoServoAction { ServoIndex = 1, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 1, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 1, Engaged = false },
                        }
                    },
                    new AdvancedServoSequence
                    {
                        Name="SequenceServo2",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 2, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                            new AdvancedServoServoAction { ServoIndex = 2, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 2, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 2, TargetPosition = 110 },
                            new AdvancedServoServoAction { ServoIndex = 2, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 2, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 2, Engaged = false },
                        }
                    }
                }
            },
            new AdvancedServoPerformance
            {
                Name = "Performance1B",
                Description = "Performance1B Description",
                Loops = 1,
                PlayInParallel = false,
                ContinueWith = "",

                AdvancedServoSequences = new[]
                {
                    new AdvancedServoSequence
                    {
                        Host = new Host
                        {
                            Name = "psbc11",
                            IPAddress = "192.168.150.11",
                            Port = 5001,
                            AdvancedServos = new[]
                            {
                                new AdvancedServo
                                {
                                    Name = "AdvancedServo 1",
                                    SerialNumber = 99415,
                                    Open = true
                                }
                            }
                        },
                        Name="SequenceServo0",
                        ContinueWith="SequenceServo1",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 4, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                            new AdvancedServoServoAction { ServoIndex = 4, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 4, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 4, TargetPosition = 110 },
                            new AdvancedServoServoAction { ServoIndex = 4, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 4, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 4, Engaged = false },
                        }
                    },
                    new AdvancedServoSequence
                    {
                        Name="SequenceServo1",
                        ContinueWith="SequenceServo2",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 5, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                            new AdvancedServoServoAction { ServoIndex = 5, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 5, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 5, TargetPosition = 110 },
                            new AdvancedServoServoAction { ServoIndex = 5, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 5, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 5, Engaged = false },
                        }
                    },
                    new AdvancedServoSequence
                    {
                        Name="SequenceServo2",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 6, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                            new AdvancedServoServoAction { ServoIndex = 6, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 6, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 6, TargetPosition = 110 },
                            new AdvancedServoServoAction { ServoIndex = 6, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 6, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 6, Engaged = false },
                        }
                    }
                }
            },

            new AdvancedServoPerformance
            {
                Name = "Performance2",
                Description = "Performance2 Description",
                Loops = 1,
                PlayInParallel = false,
                ContinueWith = "",

                AdvancedServoSequences = new[]
                {
                    new AdvancedServoSequence
                    {
                        Host = new Host
                        {
                            Name = "psbc21",
                            IPAddress = "192.168.150.21",
                            Port = 5001,
                            AdvancedServos = new[]
                            {
                                new AdvancedServo
                                {
                                    Name = "AdvancedServo 1",
                                    SerialNumber = 99415,
                                    Open = true
                                }
                            }
                        },
                        Name="SequenceServo0",
                        ContinueWith="SequenceServo1",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 0, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                            new AdvancedServoServoAction { ServoIndex = 0, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 0, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 0, TargetPosition = 110 },
                            new AdvancedServoServoAction { ServoIndex = 0, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 0, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 0, Engaged = false },
                        }
                    },
                    new AdvancedServoSequence
                    {
                        Name="SequenceServo1",
                        ContinueWith="SequenceServo2",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 1, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                            new AdvancedServoServoAction { ServoIndex = 1, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 1, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 1, TargetPosition = 110 },
                            new AdvancedServoServoAction { ServoIndex = 1, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 1, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 1, Engaged = false },
                        }
                    },
                    new AdvancedServoSequence
                    {
                        Name="SequenceServo2",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 2, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                            new AdvancedServoServoAction { ServoIndex = 2, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 2, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 2, TargetPosition = 110 },
                            new AdvancedServoServoAction { ServoIndex = 2, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 2, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 2, Engaged = false },
                        }
                    }
                }
            },
            new AdvancedServoPerformance
            {
                Name = "Performance2B",
                Description = "Performance2B Description",
                Loops = 1,
                PlayInParallel = false,
                ContinueWith = "",

                AdvancedServoSequences = new[]
                {
                    new AdvancedServoSequence
                    {
                        Host = new Host
                        {
                            Name = "psbc21",
                            IPAddress = "192.168.150.21",
                            Port = 5001,
                            AdvancedServos = new[]
                            {
                                new AdvancedServo
                                {
                                    Name = "AdvancedServo 1",
                                    SerialNumber = 99415,
                                    Open = true
                                }
                            }
                        },
                        Name="SequenceServo0",
                        ContinueWith="SequenceServo1",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 4, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                            new AdvancedServoServoAction { ServoIndex = 4, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 4, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 4, TargetPosition = 110 },
                            new AdvancedServoServoAction { ServoIndex = 4, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 4, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 4, Engaged = false },
                        }
                    },
                    new AdvancedServoSequence
                    {
                        Name="SequenceServo1",
                        ContinueWith="SequenceServo2",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 5, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                            new AdvancedServoServoAction { ServoIndex = 5, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 5, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 5, TargetPosition = 110 },
                            new AdvancedServoServoAction { ServoIndex = 5, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 5, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 5, Engaged = false },
                        }
                    },
                    new AdvancedServoSequence
                    {
                        Name="SequenceServo2",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 6, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                            new AdvancedServoServoAction { ServoIndex = 6, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 6, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 6, TargetPosition = 110 },
                            new AdvancedServoServoAction { ServoIndex = 6, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 6, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 6, Engaged = false },
                        }
                    }
                }
            },

            new AdvancedServoPerformance
            {
                Name = "Performance2 Parallel",
                Description = "Performance2 Parallel Description",
                Loops = 1,
                PlayInParallel = false,
                ContinueWith = "",

                AdvancedServoSequences = new[]
                {
                    new AdvancedServoSequence
                    {
                        Host = new Host
                        {
                            Name = "psbc21",
                            IPAddress = "192.168.150.21",
                            Port = 5001,
                            AdvancedServos = new[]
                            {
                                new AdvancedServo
                                {
                                    Name = "AdvancedServo 1",
                                    SerialNumber = 99415,
                                    Open = true
                                }
                            }
                        },
                        Name="SequenceServo0P Configure and Engage",
                        PlayInParallel = true,
                        ContinueWith = "SequenceServo1P",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 0, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                            new AdvancedServoServoAction { ServoIndex = 1, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                            new AdvancedServoServoAction { ServoIndex = 2, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                        }
                    },
                    new AdvancedServoSequence
                    {
                        Name="SequenceServo1P",
                        PlayInParallel = true,
                        ContinueWith="SequenceServo2P",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 0, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 1, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 2, TargetPosition = 90 },

                        }
                    },
                    new AdvancedServoSequence
                    {
                        Name="SequenceServo2P",
                        PlayInParallel = true,
                        ContinueWith="SequenceServo3P",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 0, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 1, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 2, TargetPosition = 100 },

                        }
                    },
                    new AdvancedServoSequence
                    {
                        Name="SequenceServo3P",
                        PlayInParallel = true,
                        ContinueWith="SequenceServo4P",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 0, TargetPosition = 110 },
                            new AdvancedServoServoAction { ServoIndex = 1, TargetPosition = 110 },
                            new AdvancedServoServoAction { ServoIndex = 2, TargetPosition = 110 },

                        }
                    },
                    new AdvancedServoSequence
                    {
                        Name="SequenceServo4P",
                        PlayInParallel = true,
                        ContinueWith="SequenceServo5P",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 0, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 1, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 2, TargetPosition = 100 },
                        }
                    },
                    new AdvancedServoSequence
                    {
                        Name="SequenceServo5P",
                        PlayInParallel = true,
                        ContinueWith="SequenceServoFin",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 0, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 1, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 2, TargetPosition = 90 },
                        }
                    },
                    new AdvancedServoSequence
                    {
                        Name="SequenceServoFin",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 0, Engaged = false },
                            new AdvancedServoServoAction { ServoIndex = 1, Engaged = false },
                            new AdvancedServoServoAction { ServoIndex = 2, Engaged = false },
                        }
                    }
                }
            },
            new AdvancedServoPerformance
            {
                Name = "Performance2B Parallel",
                Description = "Performance2 Parallel Description",
                Loops = 1,
                PlayInParallel = false,
                ContinueWith = "",

                AdvancedServoSequences = new[]
                {
                    new AdvancedServoSequence
                    {
                        Host = new Host
                        {
                            Name = "psbc21",
                            IPAddress = "192.168.150.21",
                            Port = 5001,
                            AdvancedServos = new[]
                            {
                                new AdvancedServo
                                {
                                    Name = "AdvancedServo 1",
                                    SerialNumber = 99415,
                                    Open = true
                                }
                            }
                        },
                        Name="SequenceServo0P Configure and Engage",
                        PlayInParallel = true,
                        ContinueWith = "SequenceServo1P",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 4, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                            new AdvancedServoServoAction { ServoIndex = 5, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                            new AdvancedServoServoAction { ServoIndex = 6, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                        }
                    },
                    new AdvancedServoSequence
                    {
                        Name="SequenceServo1P",
                        PlayInParallel = true,
                        ContinueWith="SequenceServo2P",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 4, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 5, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 6, TargetPosition = 90 },

                        }
                    },
                    new AdvancedServoSequence
                    {
                        Name="SequenceServo2P",
                        PlayInParallel = true,
                        ContinueWith="SequenceServo3P",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 4, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 5, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 6, TargetPosition = 100 },

                        }
                    },
                    new AdvancedServoSequence
                    {
                        Name="SequenceServo3P",
                        PlayInParallel = true,
                        ContinueWith="SequenceServo4P",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 4, TargetPosition = 110 },
                            new AdvancedServoServoAction { ServoIndex = 5, TargetPosition = 110 },
                            new AdvancedServoServoAction { ServoIndex = 6, TargetPosition = 110 },

                        }
                    },
                    new AdvancedServoSequence
                    {
                        Name="SequenceServo4P",
                        PlayInParallel = true,
                        ContinueWith="SequenceServo5P",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 4, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 5, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 6, TargetPosition = 100 },
                        }
                    },
                    new AdvancedServoSequence
                    {
                        Name="SequenceServo5P",
                        PlayInParallel = true,
                        ContinueWith="SequenceServoFin",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 4, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 5, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 6, TargetPosition = 90 },
                        }
                    },
                    new AdvancedServoSequence
                    {
                        Name="SequenceServoFin",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 4, Engaged = false },
                            new AdvancedServoServoAction { ServoIndex = 5, Engaged = false },
                            new AdvancedServoServoAction { ServoIndex = 6, Engaged = false },
                        }
                    }
                }
            },

            new AdvancedServoPerformance
            {
                Name = "Performance3",
                Description = "Performance3 Description",
                Loops = 1,
                PlayInParallel = false,
                ContinueWith = "",

                AdvancedServoSequences = new[]
                {
                    new AdvancedServoSequence
                    {
                        Host = new Host
                        {
                            Name = "psbc22",
                            IPAddress = "192.168.150.22",
                            Port = 5001,
                            AdvancedServos = new[]
                            {
                                new AdvancedServo
                                {
                                    Name = "AdvancedServo 1",
                                    SerialNumber = 99415,
                                    Open = true
                                }
                            }
                        },
                        Name="SequenceServo0",
                        ContinueWith="SequenceServo1",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 0, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                            new AdvancedServoServoAction { ServoIndex = 0, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 0, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 0, TargetPosition = 110 },
                            new AdvancedServoServoAction { ServoIndex = 0, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 0, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 0, Engaged = false },
                        }
                    },
                    new AdvancedServoSequence
                    {
                        Name="SequenceServo1",
                        ContinueWith="SequenceServo2",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 1, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                            new AdvancedServoServoAction { ServoIndex = 1, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 1, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 1, TargetPosition = 110 },
                            new AdvancedServoServoAction { ServoIndex = 1, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 1, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 1, Engaged = false },
                        }
                    },
                    new AdvancedServoSequence
                    {
                        Name="SequenceServo2",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 2, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                            new AdvancedServoServoAction { ServoIndex = 2, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 2, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 2, TargetPosition = 110 },
                            new AdvancedServoServoAction { ServoIndex = 2, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 2, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 2, Engaged = false },
                        }
                    }
                }
            },
            new AdvancedServoPerformance
            {
                Name = "Performance3B",
                Description = "Performance3B Description",
                Loops = 1,
                PlayInParallel = false,
                ContinueWith = "",

                AdvancedServoSequences = new[]
                {
                    new AdvancedServoSequence
                    {
                        Host = new Host
                        {
                            Name = "psbc22",
                            IPAddress = "192.168.150.22",
                            Port = 5001,
                            AdvancedServos = new[]
                            {
                                new AdvancedServo
                                {
                                    Name = "AdvancedServo 1",
                                    SerialNumber = 99415,
                                    Open = true
                                }
                            }
                        },
                        Name="SequenceServo0",
                        ContinueWith="SequenceServo1",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 4, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                            new AdvancedServoServoAction { ServoIndex = 4, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 4, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 4, TargetPosition = 110 },
                            new AdvancedServoServoAction { ServoIndex = 4, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 4, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 4, Engaged = false },
                        }
                    },
                    new AdvancedServoSequence
                    {
                        Name="SequenceServo1",
                        ContinueWith="SequenceServo2",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 5, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                            new AdvancedServoServoAction { ServoIndex = 5, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 5, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 5, TargetPosition = 110 },
                            new AdvancedServoServoAction { ServoIndex = 5, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 5, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 5, Engaged = false },
                        }
                    },
                    new AdvancedServoSequence
                    {
                        Name="SequenceServo2",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 6, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                            new AdvancedServoServoAction { ServoIndex = 6, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 6, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 6, TargetPosition = 110 },
                            new AdvancedServoServoAction { ServoIndex = 6, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 6, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 6, Engaged = false },
                        }
                    }
                }
            },

            new AdvancedServoPerformance
            {
                Name = "Performance4",
                Description = "Performance4 Description",
                Loops = 1,
                PlayInParallel = false,
                ContinueWith = "",

                AdvancedServoSequences = new[]
                {
                    new AdvancedServoSequence
                    {
                        Host = new Host
                        {
                            Name = "psbc23",
                            IPAddress = "192.168.150.23",
                            Port = 5001,
                            AdvancedServos = new[]
                            {
                                new AdvancedServo
                                {
                                    Name = "AdvancedServo 1",
                                    SerialNumber = 99415,
                                    Open = true
                                }
                            }
                        },
                        Name="SequenceServo0",
                        ContinueWith="SequenceServo1",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 0, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                            new AdvancedServoServoAction { ServoIndex = 0, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 0, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 0, TargetPosition = 110 },
                            new AdvancedServoServoAction { ServoIndex = 0, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 0, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 0, Engaged = false },
                        }
                    },
                    new AdvancedServoSequence
                    {
                        Name="SequenceServo1",
                        ContinueWith="SequenceServo2",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 1, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                            new AdvancedServoServoAction { ServoIndex = 1, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 1, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 1, TargetPosition = 110 },
                            new AdvancedServoServoAction { ServoIndex = 1, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 1, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 1, Engaged = false },
                        }
                    },
                    new AdvancedServoSequence
                    {
                        Name="SequenceServo2",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 2, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                            new AdvancedServoServoAction { ServoIndex = 2, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 2, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 2, TargetPosition = 110 },
                            new AdvancedServoServoAction { ServoIndex = 2, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 2, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 2, Engaged = false },
                        }
                    }
                }
            },
            new AdvancedServoPerformance
            {
                Name = "Performance4B",
                Description = "Performance4B Description",
                Loops = 1,
                PlayInParallel = false,
                ContinueWith = "",

                AdvancedServoSequences = new[]
                {
                    new AdvancedServoSequence
                    {
                        Host = new Host
                        {
                            Name = "psbc23",
                            IPAddress = "192.168.150.23",
                            Port = 5001,
                            AdvancedServos = new[]
                            {
                                new AdvancedServo
                                {
                                    Name = "AdvancedServo 1",
                                    SerialNumber = 99415,
                                    Open = true
                                }
                            }
                        },
                        Name="SequenceServo0",
                        ContinueWith="SequenceServo1",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 4, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                            new AdvancedServoServoAction { ServoIndex = 4, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 4, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 4, TargetPosition = 110 },
                            new AdvancedServoServoAction { ServoIndex = 4, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 4, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 4, Engaged = false },
                        }
                    },
                    new AdvancedServoSequence
                    {
                        Name="SequenceServo1",
                        ContinueWith="SequenceServo2",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 5, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                            new AdvancedServoServoAction { ServoIndex = 5, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 5, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 5, TargetPosition = 110 },
                            new AdvancedServoServoAction { ServoIndex = 5, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 5, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 5, Engaged = false },
                        }
                    },
                    new AdvancedServoSequence
                    {
                        Name="SequenceServo2",

                        AdvancedServoServoActions = new[]
                        {
                            new AdvancedServoServoAction { ServoIndex = 6, Acceleration = 5000, VelocityLimit = 200, Engaged = true },
                            new AdvancedServoServoAction { ServoIndex = 6, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 6, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 6, TargetPosition = 110 },
                            new AdvancedServoServoAction { ServoIndex = 6, TargetPosition = 100 },
                            new AdvancedServoServoAction { ServoIndex = 6, TargetPosition = 90 },
                            new AdvancedServoServoAction { ServoIndex = 6, Engaged = false },
                        }
                    }
                }
            }
        };
    }
}

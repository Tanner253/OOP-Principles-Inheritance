﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.classes
{
    class SpeedBoat : Boat , IHasBow
    {
        public override bool Floats { get; set; }
        public override int HasFlag { get; set; }
        public override bool Flys { get; set ; }
        public override bool Starts { get; set; }
        public override bool MakesNoise { get; set ; }


        public bool IHasBow(IHasBow hasBow)
        {
            return true;
        }

        public override void Drives()
        {
            Console.WriteLine("The Boat is going somewhere.");
        }

        public override void TurnOff()
        {
            Console.WriteLine("The boat has turned off.");
        }

        public override void TurnOn()
        {
            Console.WriteLine("The boat has turned on.");
        }
    }
}

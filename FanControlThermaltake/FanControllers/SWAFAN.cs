﻿using HidSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanControl.Thermaltake.FanControllers
{
    public class SWAFAN : TTFanController, TTFanControllerInterface
    {
        public override string Name => "SWAFAN";
        public override int PortCount => 5;

        public override int ProductIdStart => 0x232b;
        public override int ProductIdEnd => 0x233B;
    }
}

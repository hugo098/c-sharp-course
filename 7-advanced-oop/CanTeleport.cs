﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CanTeleport : ITeleports
    {
        public string teleport()
        {
            return "Teleports away";
        }
    }
}

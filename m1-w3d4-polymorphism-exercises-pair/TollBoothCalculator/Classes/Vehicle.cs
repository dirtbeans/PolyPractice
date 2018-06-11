﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator
{
     interface IVehicle
    {
        double CalculateToll(int distance);

        string NameOfVehicle
        {
            get;
        }
    }
}

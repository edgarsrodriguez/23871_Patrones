﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180202_Practica01.Interfaces
{
    public interface IObserver
    {
        void update(double temp, double pres, double hum);
    }
}

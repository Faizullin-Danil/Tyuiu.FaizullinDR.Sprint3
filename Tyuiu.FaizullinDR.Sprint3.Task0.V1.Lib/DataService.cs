﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.FaizullinDR.Sprint3.Task0.V1.Lib
{
    public class DataService : ISprint3Task0V1
    {
        public double GetSumSeries(double value)
        {
            double res = 0;
            for (int i = 1; i <= 15; i++)
            {
                res += value * value * i + 1;
            }
            return res;
        }
    }
}

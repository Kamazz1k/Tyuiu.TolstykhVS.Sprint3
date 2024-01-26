﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TolstykhVS.Sprint3.Task2V7.Lib
{
    public class DataService : ISprint3Task2V7
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sumSeries = 1;
            do
            {
                sumSeries *= Math.Pow((1 / Math.Sin(startValue)), 2);
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(sumSeries, 3);
        }
    }
}

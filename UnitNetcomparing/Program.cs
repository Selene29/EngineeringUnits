﻿using EngineeringUnits;
using EngineeringUnits.Units;
using Fractions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace UnitNetcomparing
{
    class Program
    {
        static void Main(string[] args)
        {



            List<double> list = new List<double> { 1, 1.2, 0.2, 1.8, 0.5 };
            Debug.Print(list.Min().ToString());
            double lenght = 50; //cm
            double time = 4; //seconds
            double speed = lenght / time; // m/s
            double speed2 = time / lenght; // m/s

            
            
            
            Length lenght2 = Length.FromCentimeter(50);
            Duration time2 = Duration.FromSecond(4);

            Speed speed3 = lenght2 / time2;
            //Speed speed4 = time2 / lenght2;


            Debug.Print($"{speed3}");
            Debug.Print($"{speed3.As(SpeedUnit.MeterPerSecond)}");
            Debug.Print($"{speed3.As(SpeedUnit.MeterPerMinute)}");


            var watch = System.Diagnostics.Stopwatch.StartNew();




            Area SqrtTest = Area.FromSI(9);
            Length L2 = Length.FromSI(-2);
            Length L5 = Length.FromFoot(5);
            Length L6 = Length.FromFoot(-10);
            Length L7 = Length.FromFoot(10);

            List<Length> listofl = new List<Length>() { L2, L5 , L6, L7 };

            var test111 = listofl.Abs();

            foreach (var item in test111)
            {
                Debug.Print($"{item}");
            }



            Debug.Print(L2.Unit.GetHashCode().ToString());
            Debug.Print(L5.Unit.GetHashCode().ToString());
            Debug.Print(L6.Unit.GetHashCode().ToString());
            Debug.Print(L7.Unit.GetHashCode().ToString());


            Area Lmix = L2 * L5;


            Length SqrtTest2 = Lmix.Sqrt();


            var local = Lmix.Unit.ReduceUnits();
            var local2 = Lmix.Unit.ReduceUnitsHard();


            Length L10 = Length.FromSI(10);


            //List<Length> listOfL = new List<Length>();

            //listOfL.Add(L2);
            //listOfL.Add(L5);
            //listOfL.Add(L10);

            //var local = listOfL.RoundDownToNearest(Length.FromSI(1));

            //var test122 = new Density(1, DensityUnit.GramPerCubicCentimeter);


            //Debug.Print(test122.Unit.GetHashCode().ToString());

            Power P2 = Power.FromSI(10);
            //Length L2 = Length.FromSI(2);
            Temperature T2 = Temperature.FromSI(4);

            double ThermalConductivityAsSI = 0;
            double PowerAsSI = P2.SI;
            double LengthAsSI = L2.SI;
            double TemperatureAsSI = T2.SI;

            //Solver or function where calculation speed is critical!
            for (int i = 0; i < 1000000000; i++)
            {
                ThermalConductivityAsSI = PowerAsSI / (LengthAsSI * TemperatureAsSI);
            }

            ThermalConductivity Result = ThermalConductivity.FromSI(ThermalConductivityAsSI);


            //ThermalConductivity test = 0;
           // var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                ThermalConductivity TC = P2 / (L2 * T2);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            Console.WriteLine(elapsedMs.ToString());
            Console.ReadLine();

  

        }
    }
}

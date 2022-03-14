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

            Length _L1 = Length.FromSI(1);
            Length _L2 = Length.FromSI(2);

            double Dicided = 0;

            for (int i = 0; i < 10000000; i++)
            {
                //testunit = ProfileTest.Unit.GetHashCodeForUnitCompare();

                Dicided = _L1/_L2;

            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;










            Type objType = typeof(AccelerationUnit);

            // Print the assembly full name.
            Console.WriteLine($"Assembly full name:\n   {objType.Assembly.FullName}.");

            // Print the assembly qualified name.
            Console.WriteLine($"Assembly qualified name:\n   {objType.AssemblyQualifiedName}.");



            List<string> name = new List<string>() { "Acceleration", "Angle", "ApparentPower", "AreaDensity", "AreaMomentOfInertia", "Area", "BitRate", "BrakeSpecificFuelConsumption", "Capacitance", "CoefficientOfThermalExpansion", "Density", "DynamicViscosity", "ElectricChargeDensity", "ElectricCharge", "ElectricConductivity", "ElectricCurrentDensity", "ElectricCurrentGradient", "ElectricField", "ElectricInductance", "ElectricPotentialChangeRate", "ElectricPotential", "MolarMass", "ElectricResistance", "ElectricResistivity", "ElectricSurfaceChargeDensity", "Energy", "Entropy", "ForceChangeRate", "ForcePerLength", "Force", "Frequency", "FuelEfficiency", "HeatFlux", "HeatTransferCoefficient", "Illuminance", "Information", "Irradiance", "Irradiation", "KinematicViscosity", "LapseRate", "LinearDensity", "LinearPowerDensity", "LuminousFlux", "MagneticField", "MagneticFlux", "Magnetization", "MassFlow", "MassFlux", "MassMomentOfInertia", "MolarEnergy", "MolarEntropy", "Molarity", "Permeability", "Permittivity", "PowerDensity", "Power", "PressureChangeRate", "Pressure", "Ratio", "ReactiveEnergy", "ReactivePower", "RotationalSpeed", "SpecificEnergy", "SpecificEntropy", "SpecificWeight", "Speed", "TemperatureChangeRate", "ThermalConductivity", "ThermalResistance", "TorquePerLength", "Torque", "VolumeFlow", "VolumePerLength", "Volume", "WarpingMomentOfInertia", "SpecificThermalResistance" };
           
           


            for (int index =0; index < name.Count; index++) { 
            var t =Type.GetType("EngineeringUnits.Units."+name[index]+"Unit, EngineeringUnits");

                foreach (var item in t.GetFields())
            {
                Debug.Print(item.Name);
            }

            

                        

            //foreach (var field in t.GetFields(BindingFlags.Static | BindingFlags.Public))
            //{
            //    var localunit = field.GetValue(field);
            //    localunit.QuantityName = field.Name;

            //}


            //Debug.Print($"{listOfLenghts.Mean()}");



            





            //var listOfLenghts = new List<Length>() { };


            //Debug.Print($"{listOfLenghts.Mean()}");









            //        var unitasstring = Enumeration.ListOf<AccelerationUnit>();








    //        double P = 10.0;
    //        double L = 2.0;
    //        double T = 4.0;


         //SpecificThermalResistance expected = (Length.FromMeters(L) * Temperature.FromKelvins(T)) / Power.FromWatts(P);
         //   //
         //   Debug.Print(expected.Value.ToString());
    //
    //
    //
    //        ThermalConductivity actual = Power.FromWatts(P) / (Length.FromMeters(L) * Temperature.FromKelvins(T));


            }


            //        Debug.Print($"{expected}");

            //        Debug.Print($"{1/actual}");


                    //Debug.Print($"");

            //        Debug.Print($"{1/actual}");




            //        SpecificThermalResistance STR = new SpecificThermalResistance(10, SpecificThermalResistanceUnit.MeterKelvinPerKilowatt);
            //        SpecificThermalResistance STR2 = (Length.FromMeters(3.2) * Temperature.FromKelvins(10)) / Power.FromWatts(23);

            //        ThermalConductivity TC = 1/STR;


            //        SpecificThermalResistance STR = new SpecificThermalResistance(10, SpecificThermalResistanceUnit.MeterKelvinPerKilowatt);
            //        SpecificThermalResistance STR2 = (Length.FromMeters(3.2) * Temperature.FromKelvins(10)) / Power.FromWatts(23);


            //        Debug.Print($"{STR}");
            //        Debug.Print($"{STR2}");
            //        Debug.Print($"{TC}");

            //        //Two Different ways of creating a new unit
            //        Length length = Length.FromYards(1);
            //        Length length2 = Length.FromYards(2);

            //        //Display the unis as it was created
            //        Debug.Print($"{length}"); //1 yd

            //        //Returns as a other unit
            //        Debug.Print($"{length.ToUnit(LengthUnit.Meter)}"); //0.9144 m

            //        //Returns as a double
            //        Debug.Print($"{length.As(LengthUnit.Meter)}"); //0.9144


            //        //Returns as a other unit
            //        Debug.Print($"{length.ToUnit(LengthUnit.Meter)}"); //0.9144 m

            //        //Returns as a double
            //        Debug.Print($"{length.As(LengthUnit.Meter)}"); //0.9144





            //        Area NewUnit = listOfLenghts
            //                       .Average()
            //                       .Pow(2)
            //                       .ToUnit(AreaUnit.SquareMeter);

            //        //Length lenghtAvg = list.Average();

            //        //Area area2 = length * length2 * length2 ;

            //        Area area3 = Area.FromSquareYards(1);

            //        //var unitasstring = Enumeration.GetUnitByString<LengthUnit>("Kilometer");

            //        double? c = null;
            //      //var test = Power.From(c,null);


            //        //var unitasstring = Enumeration.GetUnitByString<LengthUnit>("Kilometer");


            //        // Typical formats
            //        Debug.Print("UnitNets: " + length.ToString("S4")); // 3.14 cm
            //        //Debug.Print("EngineeringUnits: " + length2.ToString("S4")); // 3.14 cm



            //        // Typical formats
            //        Debug.Print("UnitNets: " + length.ToString("S4")); // 3.14 cm
            //        //Debug.Print("EngineeringUnits: " + length2.ToString("S4")); // 3.14 cm


            //        //Made a special case for frequency for now

            //        //Create unit based on UnitSystem 
            //        //and make the unit check at that time?

            //        //UnknownUnit Abs() could we create it as some kind af generic so we dont have to cast it to and from UnknownUnit

            //        Temperature T112 = new(20, TemperatureUnit.DegreeCelsius);


            //        //UnknownUnit Abs() could we create it as some kind af generic so we dont have to cast it to and from UnknownUnit


            //        SpecificEnergy EngineeringUnits1 = new(1, SpecificEnergyUnit.BtuPerPound);

            //        var tst = (EngineeringUnits1 + EngineeringUnits1).ToUnit(SpecificEnergyUnit.BtuPerPound);

            //        Debug.Print(EngineeringUnits1.ToString("N4"));


            //        var tst = (EngineeringUnits1 + EngineeringUnits1).ToUnit(SpecificEnergyUnit.BtuPerPound);


            //        //EngineeringUnits1.Unit.ReduceUnits();



            //        //EngineeringUnits1.Unit.ReduceUnits();


            //        Debug.Print($"{EngineeringUnits1.As(SpecificEnergyUnit.JoulePerKilogram)}");

            //        SpecificEnergy EngineeringUnits2 = new(10, SpecificEnergyUnit.JoulePerKilogram);

            //        SpecificEnergy EngineeringUnits3 = EngineeringUnits1 + EngineeringUnits2;


            //        SpecificEnergy EngineeringUnits2 = new(10, SpecificEnergyUnit.JoulePerKilogram);


            //        var A4 = new EngineeringUnits.Length(10, LengthUnit.Kilometer);
            //        var A5 = new EngineeringUnits.Duration(1, DurationUnit.Minute);
            //        var A6 = new EngineeringUnits.Duration(1, DurationUnit.Hour);

            //        var test56 = (A5 * A6);

            //        Acceleration Result2 = A4 / (A5 * A6);


            //        var test56 = (A5 * A6);

            //        Acceleration Result2 = A4 / (A5 * A6);


            //        var A3 = new Acceleration(1, AccelerationUnit.SI);



            //        var A3 = new Acceleration(1, AccelerationUnit.SI);


            //        Debug.Print(A3.As(AccelerationUnit.StandardGravity).ToString());


            //        //Precise Convertions
            //        Length L2 = new Length(1, LengthUnit.Inch);
            //        Length L3 = new Length(1, LengthUnit.Hand);


            //        //var A4 = L2 + L3;



            //        //var A4 = L2 + L3;



            //        SpecificEnergy EE1 = new SpecificEnergy(84100, SpecificEnergyUnit.JoulePerKilogram);
            //        SpecificEnergy EE2 = new SpecificEnergy(3907000000000000d, SpecificEnergyUnit.JoulePerKilogram);

            //        MassFlow MMM1 = new MassFlow(3.47e+13, MassFlowUnit.KilogramPerSecond);


            //        SpecificEnergy EE1 = new SpecificEnergy(84100, SpecificEnergyUnit.JoulePerKilogram);
            //        SpecificEnergy EE2 = new SpecificEnergy(3907000000000000d, SpecificEnergyUnit.JoulePerKilogram);


            //        Power PP1 = (EE2 - EE1) * MMM1;

            //        Mass M1 = new Mass(4300.125, MassUnit.Kilogram);
            //        Mass M2 = new Mass(2, MassUnit.Megapound);
            //        Mass M3 = new Mass(77644, MassUnit.Milligram);
            //        Mass M4 = new Mass(345, MassUnit.Pound);


            //        Power PP1 = (EE2 - EE1) * MMM1;


            //        Debug.Print($"{M1.ToString("g5")}");

            //        Length L11 = new Length(54.3, LengthUnit.Foot); //16.55064 m

            //        Area A11 = L11.Pow(2);  //273.9236844096 m²    

            //        //Length L21 = A11.Sqrt(); //16.55064 m


            //        Area A11 = L11.Pow(2);  //273.9236844096 m²    


            //        if (M4.IsNotZero())
            //        {

            //        }

            //        Mass MinMass = UnitMath.Min(M1, M2, M3, M4);    //7.764e+04 mg
            //        Mass MaxMass = UnitMath.Max(M1, M2, M3, M4);    //2 Mlb
            //        Mass MaxAvg = UnitMath.Average(M1, M2, M3, M4); //2.268e+05 kg
            //        Mass MaxSum = UnitMath.Sum(M1, M2, M3, M4);     //9.074e+05 kg


            //        }


            //        //Inf

            //        Mass mass = new Mass(10, MassUnit.Kilogram);
            //        Volume volume = new Volume(0, VolumeUnit.CubicMeter);

            //        Density D1 = mass / volume; // 2.5 kg/m³
            //        //Density D2 = volume / mass; // WrongUnitException: 'This is NOT a [kg/m³] as expected! Your Unit is a [m³/kg]'

            //        Debug.Print(mass.GetHashCode().ToString());
            //        Debug.Print(volume.GetHashCode().ToString());
            //        Debug.Print(D1.GetHashCode().ToString());


            //        Density D1 = mass / volume; // 2.5 kg/m³
            //        //Density D2 = volume / mass; // WrongUnitException: 'This is NOT a [kg/m³] as expected! Your Unit is a [m³/kg]'


            //        Pressure testtt = UnitMath.LinearInterpolation(MassFlow.FromKilogramsPerSecond(1), MassFlow.FromKilogramsPerSecond(1), MassFlow.FromKilogramsPerSecond(1), Pressure.FromBars(10), Pressure.FromBars(20));



            //        Pressure testtt = UnitMath.LinearInterpolation(MassFlow.FromKilogramsPerSecond(1), MassFlow.FromKilogramsPerSecond(1), MassFlow.FromKilogramsPerSecond(1), Pressure.FromBars(10), Pressure.FromBars(20));


            //        SpecificEnergy EEE = new SpecificEnergy(10, SpecificEnergyUnit.JoulePerKilogram);


            //        Enthalpy SSS = EEE;



            //        Enthalpy SSS = EEE;


            //        SpecificEnergy EEE2 = SSS;


            //        SpecificEnergy EEE2 = SSS;



            //        int totalcount = 1000000;
            //        Power P11 = new Power(360, PowerUnit.Kilowatt);
            //        bool speedtest = true;
            //        var watch = System.Diagnostics.Stopwatch.StartNew();



            //        for (int i = 0; i < totalcount; i++)
            //        {
            //            speedtest = Power.Zero > P11;
            //        }



            //        watch.Stop();
            //        Debug.Print($"Time: {watch.ElapsedTicks / totalcount}");



            //        RotationalSpeed F1 = new RotationalSpeed(1500, RotationalSpeedUnit.BeatPerMinute);



            //        RotationalSpeed F1 = new RotationalSpeed(1500, RotationalSpeedUnit.BeatPerMinute);



            //        Torque TQ1 = P11 / F1;

            //        MassFlow MM1 = UnitMath.Min(MassFlow.FromKilogramsPerSecond(1), MassFlow.FromKilogramsPerSecond(1) - MassFlow.FromKilogramsPerSecond(2));



            //        MassFlow MM1 = UnitMath.Min(MassFlow.FromKilogramsPerSecond(1), MassFlow.FromKilogramsPerSecond(1) - MassFlow.FromKilogramsPerSecond(2));



            //        MassFlow MM2 = MM1 - MM1;

            //        Power f1 = new Power(-19, PowerUnit.KilojoulePerHour);
            //        Power f2 = f1.InRangeOf(Power.FromWatts(-5), Power.FromWatts(5));



            //        Power f1 = new Power(-19, PowerUnit.KilojoulePerHour);
            //        Power f2 = f1.InRangeOf(Power.FromWatts(-5), Power.FromWatts(5));

            //        Power f222 = (Power.FromWatts(-50) + Power.FromWatts(5)).Abs();


            //        Power f3 = f1 + f2;
            //        Power f4 = f2 + f1;
            //        Power f5 = f4 + f3;

            //        string jsonString1 = JsonConvert.SerializeObject(f1);
            //        Power f6 = JsonConvert.DeserializeObject<Power>(jsonString1);

            //        List<Power> locallist = new List<Power>();

            //        locallist.Add(f1);
            //        locallist.Add(f1);
            //        locallist.Add(f2);
            //        locallist.Add(f3);
            //        locallist.Add(f4);
            //        locallist.Add(f5);
            //        locallist.Add(f6);

            //        string jsonString2 = JsonConvert.SerializeObject(locallist);
            //        List<Power> locallist2 = JsonConvert.DeserializeObject<List<Power>>(jsonString2);


            //        string jsonString3 = JsonConvert.SerializeObject(locallist2);


            //        Debug.Print($"{jsonString2 == jsonString3 }");


            //        Debug.Print($"{jsonString2 == jsonString3 }");

            //        //Debug.Print($"{f2}");
            //        //Debug.Print($"{f3}");
            //        //Debug.Print($"{f4}");



            //        //Debug.Print($"{f2}");
            //        //Debug.Print($"{f3}");
            //        //Debug.Print($"{f4}");

            //        //Mass mass = new Mass(1, MassUnit.Centigram);
            //        Duration d = new Duration(1, DurationUnit.Minute);

            //        MassFlow M0 = mass / d;

            //        Debug.Print($"{M0}");


            //        MassFlow M11 = new MassFlow(-10, MassFlowUnit.KilogramPerSecond);

            //        MassFlow M22 = M11.Abs();
            //        Debug.Print($"{M22}");

            //        UnknownUnit local = new UnknownUnit(M11);



            //        Debug.Print($"{local}");




            //        //IEnumerable<BaseUnit> exporters = typeof(BaseUnit)
            //        //.Assembly.GetTypes()
            //        //.Where(t => t.IsSubclassOf(typeof(BaseUnit)))
            //        //.Select(t => (BaseUnit)Activator.CreateInstance(t));


            //        //IEnumerable<BaseUnit> exporters = typeof(BaseUnit)
            //        //.Assembly.GetTypes()
            //        //.Where(t => t.IsSubclassOf(typeof(BaseUnit)))
            //        //.Select(t => (BaseUnit)Activator.CreateInstance(t));

            //        //foreach (BaseUnit item in exporters)
            //        //{
            //        //    //Print name of unit
            //        //    Console.WriteLine(item.GetType());
            //        //}


            //        //foreach (BaseUnit item in exporters)
            //        //{
            //        //    //Print name of unit
            //        //    Console.WriteLine(item.GetType());
            //        //}








            //        MassFlow Average2 = UnitMath.Average(
            //            MassFlow.FromKilogramsPerSecond(1),
            //            MassFlow.FromKilogramsPerSecond(2),
            //            MassFlow.FromKilogramsPerSecond(3),
            //            MassFlow.FromKilogramsPerSecond(4),
            //            MassFlow.FromKilogramsPerSecond(5),
            //            MassFlow.FromKilogramsPerSecond(6),
            //            MassFlow.FromKilogramsPerSecond(7),
            //MassFlow.FromKilogramsPerSecond(8),
            //MassFlow.FromKilogramsPerSecond(9),
            //MassFlow.FromKilogramsPerSecond(10)
            //);



            //        MassFlow Average2 = UnitMath.Average(
            //            MassFlow.FromKilogramsPerSecond(1),
            //            MassFlow.FromKilogramsPerSecond(2),
            //            MassFlow.FromKilogramsPerSecond(3),
            //            MassFlow.FromKilogramsPerSecond(4),
            //            MassFlow.FromKilogramsPerSecond(5),
            //            MassFlow.FromKilogramsPerSecond(6),
            //            MassFlow.FromKilogramsPerSecond(7),
            //MassFlow.FromKilogramsPerSecond(8),
            //MassFlow.FromKilogramsPerSecond(9),
            //MassFlow.FromKilogramsPerSecond(10)
            //);


            //        //How much Power (Watt) does it take to heat up the water
            //        SpecificEntropy P1 = new SpecificEntropy(1, SpecificEntropyUnit.JoulePerKilogramKelvin);
            //        //MassFlow M1 = new MassFlow(1, MassFlowUnit.KilogramPerSecond);
            //        //MassFlow M2 = new MassFlow(4, MassFlowUnit.KilogramPerSecond);
            //        Temperature T2 = new Temperature(10, TemperatureUnit.DegreeCelsius);
            //        Temperature T1 = new Temperature(5, TemperatureUnit.DegreeCelsius);

            //        Power Q1 = M1 * P1 * (T2 - T1);

            //        Debug.Print($"Result without specifying the unit: {Q1}"); //5 W

            //        Debug.Print($"{M1 * P1 * (T2 - T1)}"); //5 W

            //        //Shows in baseunit
            //        Debug.Print($"Shows result as double in BritishThermalUnitPerHour: {Q1.As(PowerUnit.BritishThermalUnitPerHour):g4}");

            //        Debug.Print($"Converting it into KilocaloriePerHour: {Q1.ToUnit(PowerUnit.KilocaloriePerHour)}");

            //        //Shows in baseunit
            //        Debug.Print(Q1.ToString());


            //        //Calculate Area of a square equal sides of 4.3 Foot
            //        Length L1 = new Length(4.3, LengthUnit.Foot);
            //        Area A1 = L1.Pow(2);

            //        Debug.Print($"Area: {A1}");





        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{



    public class LengthUnit : Enumeration
    {



        public static LengthUnit Kilometer = new LengthUnit(PreFix.kilo, BaseUnits.length);
        public static LengthUnit Meter = new LengthUnit(PreFix.SI, BaseUnits.length);
        public static LengthUnit SI = new LengthUnit(PreFix.SI, BaseUnits.length);
        public static LengthUnit Decimeter = new LengthUnit(PreFix.deci, BaseUnits.length);
        public static LengthUnit Centimeter = new LengthUnit(PreFix.centi, BaseUnits.length);
        public static LengthUnit Millimeter = new LengthUnit(PreFix.milli, BaseUnits.length);
        public static LengthUnit Nanometer = new LengthUnit(PreFix.nano, BaseUnits.length);


        public static LengthUnit Inch = new LengthUnit("in", 1m, 0.0254m, false);
        public static LengthUnit Hand = new LengthUnit("hand", 3m, 0.0254m, false);
        public static LengthUnit Foot = new LengthUnit("ft", 12, 0.0254m, false);
        public static LengthUnit Yard = new LengthUnit("yd", 36, 0.0254m, false);
        public static LengthUnit Chain = new LengthUnit("ch", 792, 0.0254m, false);
        public static LengthUnit Mile = new LengthUnit("mi", 63360, 0.0254m, false);
        public static LengthUnit Nauticalmile = new LengthUnit("nmi", 72913.3858m, 0.0254m, false);

        public static LengthUnit LightYear = new LengthUnit("ly",1, 9460730472580800m, false);
        public static LengthUnit AstronomicalUnit = new LengthUnit("au",1, 149597870700m, false);
        public static LengthUnit Parsec = new LengthUnit("pc",1, 30856775814913673m, false);



        protected LengthUnit() { }


        public LengthUnit(string symbol, decimal a1, decimal a2, bool reversed)
    : base(symbol, a1, a2, reversed)
        {
        }


        public LengthUnit(PreFix SI, BaseUnits baseunit)
: base(SI, baseunit)
        {
        }


        public static IEnumerable<LengthUnit> List()
        {
            return new[] { Inch, Hand, Foot, Yard, Chain, Nauticalmile, LightYear, AstronomicalUnit, Parsec };
        }
        // Other util methods
    }



}
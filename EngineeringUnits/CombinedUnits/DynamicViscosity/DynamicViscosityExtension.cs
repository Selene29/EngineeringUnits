using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{
    public static class DynamicViscosityUnitExtension
    {

        public static DynamicViscosity IfNullSetToZero(this DynamicViscosity? local)
        {
            if (local is not null)
            {
                return local;
            }

            return DynamicViscosity.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static DynamicViscosity? Abs(this DynamicViscosity? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   
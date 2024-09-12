using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits
{
    public static class PermittivityUnitExtension
    {

        public static Permittivity IfNullSetToZero(this Permittivity? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Permittivity.Zero;
        }


        /// <summary>
        /// Returns the absolute value
        /// </summary>
        [return: NotNullIfNotNull(nameof(a))]
        public static Permittivity? Abs(this Permittivity? a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return (-a)!;
        }

    }
}                   
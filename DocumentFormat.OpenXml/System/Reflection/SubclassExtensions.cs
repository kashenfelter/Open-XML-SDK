﻿namespace System.Reflection
{
    internal static class SubclassExtensions
    {
        /// <summary>
        /// .NET Standard 1.3 does not have an equivalent API for this, but it is fairly
        /// trivial to replicate
        /// </summary>
        public static bool IsSubclassOf(this Type p, Type c)
        {
            if (p == c)
            {
                return false;
            }

            while (p != null)
            {
                if (p == c)
                {
                    return true;
                }

                p = p.GetTypeInfo().BaseType;
            }

            return false;
        }
    }
}

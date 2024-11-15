using System;

namespace console_basics_cs
{
    internal class FundamentalsCS
    {
        public static void main()
        {
            //  Initializing variables
            Console.WriteLine("Check if prompt one is the same as prompt two.");
            var arg = Console.ReadLine();
            var kwarg = Console.ReadLine();
            //  Calling method
            
            Console.WriteLine(IsBool(arg, kwarg));
        }
        internal static bool IsBool(string arg, string kwarg)
        {
            if (arg == kwarg)
            {
                return true;
            }

            return false;
        }
    }
}

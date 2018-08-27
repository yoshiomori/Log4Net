using log4net;
using System;

namespace Log4Net
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            log.Info("ok");
            Console.ReadKey();
        }
    }
}

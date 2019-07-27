using System;

namespace PreprocessorApp
{
    class Program
    {
        static void Main(string[] args)
        {
#if Microbloggers
            Console.WriteLine("Hello World debug mode!");
#endif

#if MicrobloggersRelease
            Console.WriteLine("Hello World release mode!");
#endif

            Console.ReadKey();

        }
    }
}

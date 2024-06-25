using System;

namespace RoverControlCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            MoonRover lunakhod = new MoonRover("Lunakhod 1", 1970);
            MoonRover apollo = new MoonRover("Apollo 15", 1971);
            MarsRover sojourner = new MarsRover("Sojourner", 1997);
            Satellite sputnik = new Satellite("Sputnik", 1957);

            // directs all of our rovers
            /*
            Rover[] rovers = {lunakhod, apollo, sojourner};
            DirectAll(rovers);
            */

            // step 4, include our satellite
            // Object[] stuff = {lunakhod, apollo, sojourner, sputnik};

            // step 5, testing if the Object[] array was built correctly
            /*
            foreach (Object s in stuff)
            {
                Console.WriteLine($"Tracking a {s.GetType()}...");
            }
            */

            // step 6, creating a shared class or interface
            // we're going with the shared interface approach, less refactoring 
            IDirectable[] everything = {lunakhod, apollo, sojourner, sputnik};
            DirectAll(everything);
        }

        public static void DirectAll(IDirectable[] stuff)
        {
            foreach (IDirectable s in stuff)
            {
                Console.WriteLine(s.GetInfo());
                Console.WriteLine(s.Explore());
                Console.WriteLine(s.Collect());
            }
            
        }
    }
}
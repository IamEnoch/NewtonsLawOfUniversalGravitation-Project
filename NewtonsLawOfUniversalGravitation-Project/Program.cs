using System;

namespace NewtonsLawOfUniversalGravitation_Project
{
    class Program
    {
        //Method that calulates the force between mass M and mi and ultimately add all the forces
        //Method parameters are the default object mass and the number of objects influencing the dafault objects
        static double Force(double m,double n)
        {
            double force = 0;
            double g = Math.Pow(10, -11) * 6.674;
            for (int i = 1; i <= n; i++) 
            {
                double x = (i / 6.0) + 2;
                double y = Math.Pow(i / 4, 2) + 10;
                double f = g * x * m / y;

                force += f;
            }
            return force;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Force(3, 10));
        }
    }
}

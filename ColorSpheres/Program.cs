using System;

namespace ColorSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Sphere[] spheres = new Sphere[10];
            Random rand = new Random(5336);

            for (int i = 0; i < spheres.Length; i++)
            {
                byte red = (byte)rand.Next(byte.MaxValue+1);
                byte green = (byte)rand.Next(byte.MaxValue+1);
                byte blue = (byte)rand.Next(byte.MaxValue+1);
                
                Color color = new Color(red,green,blue);
                spheres[i] = new Sphere(color, rand.Next());
            }

            for (int i = 0; i < 50; i++)
            {
                int j = rand.Next(spheres.Length);
                int d20 = rand.Next(1,21);

                if(d20==1) spheres[j].Pop();
                else spheres[j].Throw();
            }

            for (int i = 0; i < spheres.Length; i++)
            {
                if (spheres[i].IsPopped())
                {
                    Console.WriteLine($"Sphere {i} was popped. " + 
                    $"It was thrown {spheres[i].GetTimesThrown()} times");
                }else
                {
                    Console.WriteLine($"Sphere {i} was thrown " + 
                    $"{spheres[i].GetTimesThrown()} times. " +
                    $"Color code: ({spheres[i].GetColor().GetRed()}, " +
                    $"{spheres[i].GetColor().GetGreen()}, " +
                    $"{spheres[i].GetColor().GetBlue()}, " +
                    $"{spheres[i].GetColor().GetAlpha()})");
                }
            }
        }
    }
}

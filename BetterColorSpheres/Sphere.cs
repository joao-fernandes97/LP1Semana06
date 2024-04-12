using System;

namespace BetterColorSpheres
{
    public class Sphere
    {
        public Color Color {get;}
        private int radius;
        public int Radius {get;}
        private int timesThrown;
        public int TimesThrown {get;}
        

        public Sphere(Color color, int radius)
        {
            Color = color;
            this.radius = radius;
            timesThrown = 0;
        }

        public void Pop()
        {
            radius = 0;
        }

        public void Throw()
        {
            if(radius>0) timesThrown++;
        }

        public bool IsPopped()
        {
            return radius==0;
        }
    }
}
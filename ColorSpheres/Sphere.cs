using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Sphere
    {
        private readonly Color color;
        private int radius;
        private int timesThrown;

        public Sphere(Color color, int radius)
        {
            this.color = color;
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

        public int GetTimesThrown()
        {
            return timesThrown;
        }

        public Color GetColor()
        {
            return color;
        }

        public bool IsPopped()
        {
            return radius==0;
        }
    }
}
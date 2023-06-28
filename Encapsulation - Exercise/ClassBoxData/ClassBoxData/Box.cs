using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBoxData
{
    public class Box
    {
        private double lenght;
        private double width;
        private double height;

        public Box(double lenght, double  width, double height)
        {
            this.Length = lenght;
            this.Width = width;
            this.Height = height;
        }


        public double Length
        {
            get => this.lenght;

             set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Length)} cannot be zero or negative.");
                }
                this.lenght = value;

            }

        }

        public double Width
        {
            get => this.width;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");
                }
                this.width = value;

            }

        }

        public double Height
        {
            get => this.height;

             set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Height)} cannot be zero or negative.");
                }
                this.height = value;

            }

        }

        public double SurfaceArea()
        {
            double surfaceArea = 2 * (Length * Width) + LateralSurfaceArea();
            return surfaceArea;

        }

        public double LateralSurfaceArea()
        {
            double lateralSurfaceArea = 2 * (Length * Height) + 2 * (Width * Height);
            return lateralSurfaceArea;
        }

        public double Volume()
        {
            double volume = Length * Width * Height;
            return volume;
        }


    }
}

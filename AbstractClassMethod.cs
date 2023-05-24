namespace AbstractImplementation
{
    abstract class AbstractClassMethod
    {
        public double width, height, radious;
        const float pi = 3.14F;
        public abstract double GetArea();

         class Rectangle : AbstractClassMethod
        {
            public Rectangle(double w, double h)
            {
                this.width = w;
                this.height = h;
            }
            public override double GetArea()
            {
                return width * height;
            }



        }
         class Circle : AbstractClassMethod
        {
            public Circle(double r)
            {
                this.radious = r;
            }
            public override double GetArea()
            {
                return pi * radious * radious;
            }

        }
         class Cone : AbstractClassMethod
        {
            public Cone(double h, double r)
            {
                this.height = h;
                this.radious = r;
            }
            public override double GetArea()
            {
                return pi * radious * (radious + Math.Sqrt(height * height + radious * radious));
            }

        }
        class test
        {
            static void Main()
            {
                Rectangle rc = new Rectangle(21.32, 23.5);
                Circle c = new Circle(10);
                Cone cn = new Cone(10, 5);


            }



        }
    }
}





   
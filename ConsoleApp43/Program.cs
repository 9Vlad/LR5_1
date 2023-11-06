using System;


abstract class Parent
{
    protected double pole1; 

    
    public Parent(double pole1)
    {
        this.pole1 = pole1;
    }

   
    public abstract string Info();

   
    public abstract double Metod1();

  
    public abstract double Metod2();
}


class Child1 : Parent
{
    public Child1(double pole1) : base(pole1)
    {
    }

   
    public override string Info()
    {
        return $"Тетраедр з довжиною ребра {pole1}";
    }

    
    public override double Metod1()
    {
        return Math.Sqrt(3) * pole1 * pole1;
    }

   
    public override double Metod2()
    {
        return (pole1 * pole1 * pole1) / (6 * Math.Sqrt(2));
    }
}


class Child2 : Parent
{
    public Child2(double pole1) : base(pole1)
    {
    }

    
    public override string Info()
    {
        return $"Куб з довжиною ребра {pole1}";
    }

    
    public override double Metod1()
    {
        return 6 * pole1 * pole1;
    }

   
    public override double Metod2()
    {
        return pole1 * pole1 * pole1;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        for (int i = 0; i < 5; i++)
        {
            double pole1 = random.Next(1, 11); 

            Parent obj;

            if (random.Next(2) == 0)
            {
                obj = new Child1(pole1); 
            }
            else
            {
                obj = new Child2(pole1); 
            }

            Console.WriteLine(obj.Info()); 
            Console.WriteLine($"Площа повної поверхні: {obj.Metod1()}");
            Console.WriteLine($"Обсяг: {obj.Metod2()}");
            Console.WriteLine();
        }
    }
}

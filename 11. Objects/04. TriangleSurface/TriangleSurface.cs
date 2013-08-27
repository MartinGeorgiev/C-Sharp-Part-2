//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; 
//Three sides; 
//Two sides and an angle between them. Use System.Math.

using System;

class TriangleSurface
{
    static void Main()
    {
        Console.WriteLine("Finding the triagle surface.\n");

        Console.WriteLine("Task 1: Side and an altitude to it");
        Console.WriteLine("Task 2: Three sides");
        Console.WriteLine("Task 3: Two sides and an angle between them \n");

        Console.Write("Please enter the task to solve (1 - 3): ");

        sbyte task = Convert.ToSByte(Console.ReadLine());

        while (task > 3 || task < 1)
        {
            Console.Write("ERROR! Please enter the task to solve again: ");
            task = Convert.ToSByte(Console.ReadLine());
        }

        if (task == 1)
        {
            Console.WriteLine("Surface: {0} ", SideAndAltitude());
        }

        if (task == 3)
        {
            Console.WriteLine("Surface: {0} ", TwoSideAndAngle());
        }

        if (task == 2)
        {
            Console.WriteLine("Surface: {0} ", ThreeSides());
        }
    }

    static double SideAndAltitude()
    {
        Console.Write("Please enter - side size: ");
        double side = Convert.ToDouble(Console.ReadLine());

        Console.Write("Please enter - altitude size: ");
        double altitude = Convert.ToDouble(Console.ReadLine());

        double surface = side * altitude * 0.5;
        //Area = 1/2 of the base X the height

        return surface;
    }

    static double TwoSideAndAngle()
    {
        Console.Write("Please enter - first side size: ");
        double firstSide = Convert.ToDouble(Console.ReadLine());

        Console.Write("Please enter - second side size: ");
        double secondSide = Convert.ToDouble(Console.ReadLine());

        Console.Write("Please enter - angle in degree: ");
        double angle = Convert.ToDouble(Console.ReadLine());

        angle = (angle * Math.PI)/180; //Converting degrees in radians.

        double surface = (firstSide * secondSide * Math.Sin(angle)) / 2;
        //Area = ½ · a · b · sinC

        return surface;
    }

    static double ThreeSides()
    {
        Console.Write("Please enter - first side size: ");
        double firstSide = Convert.ToDouble(Console.ReadLine());

        Console.Write("Please enter - second side size: ");
        double secondSide = Convert.ToDouble(Console.ReadLine());

        Console.Write("Please enter - third side size: ");
        double thirdSize = Convert.ToDouble(Console.ReadLine());

        //Area of a triangle = √(s(s-a)(s-b)(s-c)) by Heron's Formula
        //s == semiperimeter

        double semiPerimeter = 0.5*(firstSide + secondSide + thirdSize);

        double surface = semiPerimeter * (semiPerimeter - firstSide) * (semiPerimeter - secondSide) * (semiPerimeter - thirdSize);
        surface = Math.Sqrt(surface);

        return surface;
    }

}
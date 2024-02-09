using System;

namespace Vector_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YOOO issa calculator, that's sick");
            Console.WriteLine("please put in a vector, in the format of x,y,z");
            Vector userinput = InputVector();

            Console.WriteLine("anudda wun");
            Vector userinput2 = InputVector();

            Console.WriteLine("please give a scalar to be used later");
            double UserScalarInt = Scalar();

            Console.WriteLine((userinput + userinput2) + " / this is your Vectors added");
            Console.WriteLine((userinput - userinput2) + " / this is your Vectors subtracted");
            Console.WriteLine(" ");
            Console.WriteLine(userinput.GetMagnitude() + " / this is the Magnitude of your first vector");
            Console.WriteLine(userinput2.GetMagnitude() + " / this is the Magnitude of your second vector");
            Console.WriteLine(" ");
            Console.WriteLine(userinput.GetDirection() + " / this is the Direction of your first vector");
            Console.WriteLine(userinput2.GetDirection() + " / this is the Direction of your second vector");
            Console.WriteLine(" ");
            Console.WriteLine((-userinput) + " / this is your first vector Negated");
            Console.WriteLine((-userinput2) + " / this is your second vector Negated");
            Console.WriteLine(" ");
            Console.WriteLine((userinput * UserScalarInt) + " / this is your first vector Scaled");
            Console.WriteLine((userinput2 * UserScalarInt) + " / this is your second vector Scaled");
            Console.WriteLine(" ");
            Console.WriteLine(Vector.Normalize(userinput) + " / this is your first vector Normalized");
            Console.WriteLine(Vector.Normalize(userinput2) + " / this is your second vector Normalized");
            Console.WriteLine(" ");
            Console.WriteLine(Vector.DotProduct(userinput, userinput2) + " / this is the Dot Product between your vectors");
            Console.WriteLine(" ");
            Console.WriteLine(Vector.CrossProduct(userinput, userinput2) + " / this the Cross Product between your vectors");
            Console.WriteLine(" ");
            Console.WriteLine(Vector.AngleBetween(userinput, userinput2) + "/ this is the Angle Between your two vectors");
            Console.WriteLine(" ");
            Console.WriteLine(Vector.ProjectOnto(userinput, userinput2) + " / this is your two vectors Projected");
            Console.WriteLine(" ");
        }


        static Vector InputVector()
        {
            string UserInput = Console.ReadLine();
            float x = Convert.ToInt32(UserInput.Split(',')[0]);
            float y = Convert.ToInt32(UserInput.Split(',')[1]);
            float z = Convert.ToInt32(UserInput.Split(',')[2]);
            return new Vector(x, y, z);
        }

        static double Scalar()
        {
            string UserScaler = Console.ReadLine();

            double UserScalerInt = Convert.ToInt32(UserScaler);

            return UserScalerInt;
        }
    }
}


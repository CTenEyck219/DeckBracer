using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckFramingProgram
{

    class Frame
    {

        public double measurement = 0;
        public double numOfBraces = 0;

        public void footToInch(double foot)
        {

            measurement = foot * 12;

            numOfBraces = measurement / 16;

        }

        public double getNumBraces()
        {

            return numOfBraces;

        }

        public double getCenter()
        {

            return measurement /= 2;

        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            Frame a = new Frame();

            Console.WriteLine("What is the width of your space in feet?");
            string measurement = Console.ReadLine();

            double foot = Convert.ToDouble(measurement);
            a.footToInch(foot);

            Console.WriteLine("Center for your measurement is: {0}", a.getCenter());

            Console.WriteLine("You will need {0} bracers to complete the base frame which is" +
                " {1} inches long", a.numOfBraces, (a.measurement * 2));

            Console.ReadLine();


        }
    }
}

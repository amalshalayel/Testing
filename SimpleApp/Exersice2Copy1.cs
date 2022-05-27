using System.Text.RegularExpressions;

namespace SimpleApp
{
  public  class Exersice2Copy1
    {
        public static string TriangleType(int side1, int side2, int side3)
        {

            if (side1 <=0  || side2 <=0 ||  side3 <=0 )
            {
                return "not valid";
            }

            if (side1 == side2 && side2 == side3)
            {
                return "Equilateral";
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                return "Isosceles";
            }
            else
            {
                return "Scalene";
            }
        }
    }

}
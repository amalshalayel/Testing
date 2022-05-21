using System.Text.RegularExpressions;

class Sample
{

    private static readonly Regex regex = new Regex(@"\s+");

    public static string ReplaceWhiteSpaces(string str)
    {
        return regex.Replace(str, " ");
    }
     

    public static string TriangleType(int side1, int side2, int side3)
    {
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
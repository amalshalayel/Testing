using System.Text.RegularExpressions;

namespace SimpleApp
{
  public  class Exersice1
    {
        private static readonly Regex regex = new Regex(@"\s+");

        public static string ReplaceWhiteSpaces(string str)
        {
            return regex.Replace(str, " ");
        }
    }
}
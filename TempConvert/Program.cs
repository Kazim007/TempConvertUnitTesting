// See https://aka.ms/new-console-template for more information


static void Main()
{
}
namespace TempConvert
{
    
    public static class Convert
    {
        public static double f2c(double f)
        {
            return (f - 32) * 5 / 9;
        }
        public static double c2f(double c)
        {
            return (c * 5 / 9) + 32;
        }
    }
}

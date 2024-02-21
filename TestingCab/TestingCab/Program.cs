namespace TestingCab
{
    internal class Program
    {
        static double costPerKM = 10;
        static double costPerMin = 10;
        static double MinFare = 5;
        public double TotalFare(double distance, int time)
        {

            double totval = (distance * costPerKM) + (time * costPerMin);
            if (totval < 5)
            {
                return MinFare;
            }
            else
            {
                return totval;

            }
        }


        static void Main(string[] args)
        {
            
        }
    }
}

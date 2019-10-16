using System;

namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void Promate()
        {
            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);
            Console.WriteLine("Promate logic change");
        }
    }
}

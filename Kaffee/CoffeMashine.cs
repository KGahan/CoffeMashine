namespace Coffee
{
    public class CoffeeMashine
    {
       public double Beans { get; set;}
       public double Water { get; set;}
       public double TotalCoffeeProduced { get; set; }
        public double maxWater { get => GetMaxWater(); }
        public double maxBeans { get => GetMaxBeans(); }

        public double GetMaxBeans(){
            double maxBeans = 2.5;
            return maxBeans;
        }
        public double GetMaxWater()
        {
            double maxWater = 2.5;
            return maxWater;
        }

        public double FillUpBeans(double amount)
        {
            if ((Beans += amount) > maxBeans) { return 0; }

            Beans += amount;
            return Beans;
        }
        public double FillUpWater(double amount)
        {
            if ((Water += amount) > maxWater) { return 0; }

            Water += amount;
            return Water;
        }

        public bool makeCoffee(double amount, double WaterBeansRatio)
        {
            if(amount <= 0 && WaterBeansRatio <= 0) return false;

            var totalportions = WaterBeansRatio + 1;
            var singleportion = amount / totalportions;
            var waterAmount = singleportion * WaterBeansRatio;
            var beansAmount = amount - waterAmount;

            if (beansAmount > Beans && waterAmount > Water) {
                return false;
            }

            Water -= waterAmount;
            Beans -= beansAmount;
            TotalCoffeeProduced += amount;

            Console.WriteLine(amount);
            Console.WriteLine(waterAmount);
            Console.WriteLine(beansAmount);

            return true;
        }
    }
}
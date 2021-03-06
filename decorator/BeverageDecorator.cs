namespace decorator
{
    public abstract class BeverageDecorator : Beverage
    {
        protected Beverage beverage;

        public BeverageDecorator(Beverage beverage) : base(beverage.GetSize())
        {
            this.beverage = beverage;
        }
        public override string GetDescription()
        {
            return beverage.GetDescription();
        }
    }

    public class Chocolate : BeverageDecorator
    {
        public Chocolate(Beverage beverage) : base(beverage)
        { }

        public override string GetDescription()
        {
            return $"{beverage.GetDescription()} + Chocolate";
        }
        public override double GetCost()
        {
            return beverage.GetCost() + 0.3 * (int)beverage.GetSize();
        }
    }

    public class Milk : BeverageDecorator
    {
        public Milk(Beverage beverage) : base(beverage)
        { }

        public override string GetDescription()
        {
            return $"{beverage.GetDescription()} + Milk";
        }
        public override double GetCost()
        {
            return beverage.GetCost() + 0.2 * (int)beverage.GetSize();
        }
    }

    public class Cinnamon : BeverageDecorator
    {
        public Cinnamon(Beverage beverage) : base(beverage)
        { }

        public override string GetDescription()
        {
            return $"{beverage.GetDescription()} + Cinnamon";
        }
        public override double GetCost()
        {
            return beverage.GetCost() + 0.1 * (int)beverage.GetSize();
        }
    }
}
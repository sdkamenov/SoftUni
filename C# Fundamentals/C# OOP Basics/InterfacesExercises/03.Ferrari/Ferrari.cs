namespace _03.Ferrari
{
    public class Ferrari : ICar
    {
        public Ferrari(string driver)
        {
            Model = "488-Spider";
            Driver = driver;
        }
        public string Model {get;}

        public string Driver { get; }

        public string PushTheGasPedal()
        {
            return "Zadu6avam sA!";
        }

        public string UseBrakes()
        {
            return "Brakes!";
        }

        public override string ToString()
        {
            return $"{Model}/{UseBrakes()}/{PushTheGasPedal()}/{Driver}";
        }
    }
}

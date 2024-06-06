namespace MySolarSystem
{
    public class Planet
    {
        private string name;
        private int radius;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public double Volume => CalculateVolume();

        public Planet(string name, int radius)
        {
            Name = name;
            Radius = radius;
        }

        private double CalculateVolume()
        {
            return 4.0 / 3.0 * Math.PI * Math.Pow(Radius, 3);
        }
    }
}
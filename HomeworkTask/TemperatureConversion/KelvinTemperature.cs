namespace TemperatureConversion
{
    public class KelvinTemperature : ITemperature
    {
        public float Temperature { get; private set; }
        public KelvinTemperature() { }
        public KelvinTemperature(float temperature)
        {
            Temperature = temperature;
        }
        public float FromKelvin(float temperature)
        {
            return temperature;
        }
        public float ToKelvin()
        {
            return Temperature;
        }

    }
}
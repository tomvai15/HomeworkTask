namespace TemperatureConversion
{
    public class FahrenheitTemperature : ITemperature
    {
        public float Temperature { get; private set; }
        public FahrenheitTemperature() { }
        public FahrenheitTemperature(float temperature)
        {
            Temperature = temperature;
        }
        public float FromKelvin(float temperature)
        {
            return (temperature- 273.15f) *9/5 +32;
        }
        public float ToKelvin()
        {
            return (Temperature+459.67f)* 5/9;
        }

    }
}
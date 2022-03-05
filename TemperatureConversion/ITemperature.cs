namespace TemperatureConversion
{


    public interface ITemperature
    {
        public float ToKelvin();
        public float FromKelvin(float temperature);
    }
}
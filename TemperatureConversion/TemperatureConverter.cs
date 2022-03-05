

namespace TemperatureConversion
{
    public static class TemperatureConverter
    {
        public static float ConvertTo<T>(ITemperature temperature) where T : ITemperature, new()
        {
            return new T().FromKelvin(temperature.ToKelvin());
        }
    }
}

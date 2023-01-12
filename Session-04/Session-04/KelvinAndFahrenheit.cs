using System;

namespace Session_04
{
    public class KelvinAndFahrenheit
    {
        double celsiusTemperature = 30;
        public double ConvertCelsiusToKelvin()
        {            
            double kelvinTemperature = celsiusTemperature + 273;
            return kelvinTemperature;
        }

        public double ConvertCelsiusToFahrenheit() 
        {
            double fahrenheitTemperature = 1.8 * celsiusTemperature + 32;
            return fahrenheitTemperature;

        }
        public void printTemperatureConversion() {
            Console.WriteLine($"Temperature Conversion: {celsiusTemperature} Celsius is {ConvertCelsiusToKelvin()} " +
                              $"Kelvin and {ConvertCelsiusToFahrenheit()} Fahrenheit");
        }
    }
}
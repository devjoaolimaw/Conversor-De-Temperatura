using System;

namespace Conversor
{
    class Show
    {
        public static double CelsiusParaFahrenheit(double celcius)
        {
            return (celcius * 9 / 5) + 32;
        }

        public static double FahrenheitParaCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        public static double CelsiusParaKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        public static double KelvinParaCelsius(double kelvin)
        {
            return kelvin - 273.15;
        }

        public static double FahrenheitParaKelvin(double fahrenheit)
        {
            return CelsiusParaKelvin(FahrenheitParaCelsius(fahrenheit));
        }

        public static double KelvinParaFahrenheit(double kelvin)
        {
            return CelsiusParaFahrenheit(KelvinParaCelsius(kelvin));
        }
    }
}
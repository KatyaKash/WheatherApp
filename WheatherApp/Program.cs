using System;

namespace WeatherApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionDisplay current = new CurrentConditionDisplay(weatherData);
            StatisticsDisplay stat = new StatisticsDisplay(weatherData);


            weatherData.setMeasurments(80, 65, 30);
            weatherData.setMeasurments(82, 70, 29);
            weatherData.setMeasurments(78, 90, 29);

        }
    }
}

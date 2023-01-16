using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    internal class CurrentConditionDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;

        public CurrentConditionDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void display()
        {
            Console.WriteLine("Текущее состояние: " + temperature + "°C " + humidity + "% влажности");
        }
        public void update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            display();
        }
    }
}

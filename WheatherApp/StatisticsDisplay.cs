using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    class StatisticsDisplay : Observer, DisplayElement
    {
        private float max_temp;
        private float min_temp;
        private float temp_sum;
        private int num_readings;
        
        public StatisticsDisplay(Subject weatherData)
        {
            max_temp = 0;
            min_temp = 200;
            temp_sum = 0;
            num_readings = 0;
            weatherData.registerObserver(this);
        }
        public void display()
        {
            float avg_temp = temp_sum/ num_readings;
            Console.WriteLine("Statistics Avg/Max/Min temperature = {0}/{1}/{2}", avg_temp, max_temp, min_temp);
        }
        public void update(float temp, float humidity, float pressure)
        {
            temp_sum += temp;
            num_readings += 1;

            if (temp > max_temp)
            {
                max_temp = temp;
            }
            if (temp < min_temp)
            {
                min_temp = temp;
            }
            display();
        }
    }
}

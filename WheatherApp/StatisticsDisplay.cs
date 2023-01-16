using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    class StatisticsDisplay 
    {
        private float max_temp;
        private float min_temp;
        private float temp_sum;
        private int num_readings;
        
        public StatisticsDisplay()
        {
            max_temp = 0;
            min_temp = 200;
            temp_sum = 0;
            num_readings = 0;
        }
    }
}

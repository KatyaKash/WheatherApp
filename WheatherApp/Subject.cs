using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheatherApp
{
    internal interface Subject
    {
        public void registerObserver(Observer o);
        public void removeObserver(Observer o);
        public void notifyObservers();

    }
}

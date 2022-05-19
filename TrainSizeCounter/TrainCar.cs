using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSizeCounter
{
    public class TrainCar
    {
        private bool isLightOn;
        public bool IsLightOn {
            get { return isLightOn; }
            set {  isLightOn = value; }
         }

       
        public TrainCar(bool isLightOn)
        {
            this.isLightOn = isLightOn;
        }
    }
}

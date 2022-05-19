using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSizeCounter
{
    public class TrainGenerator
    {
        Random random = new Random();
        int size;

        public TrainGenerator(int size)
        {
            this.size = size;
        }

        public List<TrainCar> generateTrain()
        {
            List<TrainCar> trainCars = new List<TrainCar>();
            for (int i = 0; i < size; i++)
            {
                if(random.Next(2) == 0)
                {
                    trainCars.Add(new TrainCar(false));
                }
                else
                {
                    trainCars.Add(new TrainCar(true));
                }
              
            }
            return trainCars;
        }
    }
}

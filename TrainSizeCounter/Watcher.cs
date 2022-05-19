using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSizeCounter
{
    public class Watcher
    {
     

        private int position;

        private List<TrainCar> train;

        public List<TrainCar> Train
        {
            get { return train; }
            set { train = value; }
        }

        int beginPosition;

        public int BeginPosition
        {
            get { return beginPosition; }
           
        }

        public Watcher(List<TrainCar> train, int beginPosition)
        {
            this.train = train;
            this.beginPosition = beginPosition;
        }

        public int CalculateSize()
        {
            int size = 0;
            bool beginCarCondition = checkLights(train[beginPosition]);
            position = beginPosition;
         


            while (checkLights(train[beginPosition]) == beginCarCondition)
            {
                goLeft();
                size = 1;
                while(checkLights(train[position]) != beginCarCondition)
                {
                    goLeft();
                    size++;
                }
                switchLights(position);
                for (int i = 0; i < size; i++)
                {
                    goRight();
                }

            }
            return size;
        }

        public Boolean checkLights(TrainCar trainCar)
        {
            return trainCar.IsLightOn;
        }
        public void switchLights(int id)
        {
            train[id].IsLightOn = !train[id].IsLightOn;
        }

        public void goLeft()
        {
            position -= 1;
            if(position < 0)
            {
                position = train.Count-1;
            }
        }

        public void goRight()
        {
            position += 1;
            if (position == train.Count)
            {
                position = 0;
            }
        }
    }
}

namespace TrainSizeCounter
{
    public class Program
    {
        
        public static void Main(String[] args)
        {
           
            
            Console.WriteLine("Напишите количество вагонов, которое должно быть в поезде");
            int size = -1;
            while (size == -1)
            {
                try
                {
                    size = int.Parse(Console.ReadLine());
                    if (size <= 0)
                    {
                        Console.WriteLine("Число должно быть положительным!");
                        size = -1;
                    }
                }
                catch { 
                    size = -1;
                    Console.WriteLine("Число введено некорректно!");    
                }

             
            }
            TrainGenerator generator = new TrainGenerator(size);
            List<TrainCar> train = generator.generateTrain();

            Console.WriteLine("Введите вагон, с которого нужно начать считать (от 0 до " + (train.Count-1) + ")");
            int beginWagon = -1;
            while (beginWagon == -1)
            {
                try
                {
                    beginWagon = int.Parse(Console.ReadLine());
                    if (beginWagon <= 0 || beginWagon >= train.Count)
                    {
                        Console.WriteLine("Такого вагона нет!");
                        beginWagon = -1;
                    }
                }
                catch
                {
                    beginWagon = -1;
                    Console.WriteLine("Число введено некорректно!");
                }


            }

            Watcher watcher = new Watcher(train, beginWagon);
            Console.WriteLine("Количество вагонов в поезде -  " + watcher.CalculateSize());
           

        }
    }
}

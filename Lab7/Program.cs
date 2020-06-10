using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    interface IMove
    {
        void Move();
    }
    interface IStop
    {
        void Stop();
    }
    interface IOverclockingTo100
    {
        void OverclockingTo100();
    }
    abstract class Car : IMove, IStop, IOverclockingTo100, IComparable<Car>
    {
        protected string model; //стандартные поля для всех машин
        protected double cost;
        protected double gasoline_per_kilometer;
        protected double weight, length, width, height, max_speed, time_to_100;
        protected double min_speed = 0;

        public abstract double TimeTo100 { set; get; }
        public abstract double Cost { set; get; }
        public abstract double GasolinePerKilometer { set; get; }
        public abstract double Weight { set; get; }
        public abstract double Length { set; get; }
        public abstract double Width { set; get; }
        public abstract double Height { set; get; }
        public abstract double MaxSpeed { set; get; }
        public abstract double MinSpeed { get; }
        public abstract string Model { set; get; }
        public abstract string Mark { get; }
        public abstract void Move();
        public abstract void Stop();
        public abstract void OverclockingTo100();
        int IComparable<Car>.CompareTo(Car other)
        {
            int compare = this.GasolinePerKilometer.CompareTo(other.GasolinePerKilometer);
            return compare;
        }
    }

    class Audi : Car
    {
        private string mark = "AUDI";
        public override string Mark { get { return mark; } }
        public override double TimeTo100 // свойство для записи
        {
            set
            {
                if (value > 0)
                {
                    time_to_100 = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return time_to_100;
            }
        }
        public override double Cost
        {
            set
            {
                if (value > 0)
                {
                    cost = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return cost;
            }
        }

        public override double GasolinePerKilometer
        {
            set
            {
                if (value > 0)
                {
                    gasoline_per_kilometer = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return gasoline_per_kilometer;
            }
        }

        public override double Weight
        {
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return weight;
            }
        }

        public override double Length
        {
            set
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return length;
            }
        }

        public override double Width
        {
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return width;
            }
        }

        public override double Height
        {
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return height;
            }
        }

        public override double MaxSpeed
        {
            set
            {
                if (value > 0)
                {
                    max_speed = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return max_speed;
            }
        }
        public override double MinSpeed { get { return min_speed; } }
        public override string Model { set { model = value; } get { return model; } }

        public Audi(double cost, double gasoline_per_kilometer, double weight, double length, double width, double height, double max_speed, string model, double time_to_100)
        {
            this.Cost = cost;
            this.GasolinePerKilometer = gasoline_per_kilometer;
            this.Weight = weight;
            this.Length = length;
            this.Width = width;
            this.Height = height;
            this.MaxSpeed = max_speed;
            this.Model = model;
            this.TimeTo100 = time_to_100;
        }
        public override void Move()
        {
            Console.WriteLine("Едет машина с маркой AUDI с моделью {0}", model);
        }
        public override void Stop()
        {
            Console.WriteLine("Останавливается машина с маркой AUDI с моделью {0}", model);
        }
        public override void OverclockingTo100()
        {
            Console.WriteLine("Машина с маркой AUDI разгоняется до сотки за {0} секунд", time_to_100);
        }
    }
    class Sedan : Car
    {
        private string mark = "Sedan";
        public override string Mark { get { return mark; } }
        public override double TimeTo100 // свойство для записи
        {
            set
            {
                if (value > 0)
                {
                    time_to_100 = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return time_to_100;
            }
        }
        public override double Cost
        {
            set
            {
                if (value > 0)
                {
                    cost = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return cost;
            }
        }

        public override double GasolinePerKilometer
        {
            set
            {
                if (value > 0)
                {
                    gasoline_per_kilometer = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return gasoline_per_kilometer;
            }
        }

        public override double Weight
        {
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return weight;
            }
        }

        public override double Length
        {
            set
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return length;
            }
        }

        public override double Width
        {
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return width;
            }
        }

        public override double Height
        {
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return height;
            }
        }

        public override double MaxSpeed
        {
            set
            {
                if (value > 0)
                {
                    max_speed = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return max_speed;
            }
        }
        public override double MinSpeed { get { return min_speed; } }
        public override string Model { set { model = value; } get { return model; } }
        public Sedan(double cost, double gasoline_per_kilometer, double weight, double length, double width, double height, double max_speed, string model, double time_to_100)
        {
            this.Cost = cost;
            this.GasolinePerKilometer = gasoline_per_kilometer;
            this.Weight = weight;
            this.Length = length;
            this.Width = width;
            this.Height = height;
            this.MaxSpeed = max_speed;
            this.Model = model;
            this.time_to_100 = time_to_100;
        }
        public override void Move()
        {
            Console.WriteLine("Едет машина с маркой Sedan с моделью {0}", model);
        }
        public override void Stop()
        {
            Console.WriteLine("Останавливается машина с маркой Sedan с моделью {0}", model);
        }
        public override void OverclockingTo100()
        {
            Console.WriteLine("Машина с маркой Sedan разгоняется до сотки за {0} секунд", time_to_100);
        }
    }

    class Suv : Car
    {
        private string mark = "Suv";
        public override string Mark { get { return mark; } }
        public override double TimeTo100 // свойство для записи
        {
            set
            {
                if (value > 0)
                {
                    time_to_100 = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return time_to_100;
            }
        }
        public override double Cost
        {
            set
            {
                if (value > 0)
                {
                    cost = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return cost;
            }
        }

        public override double GasolinePerKilometer
        {
            set
            {
                if (value > 0)
                {
                    gasoline_per_kilometer = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return gasoline_per_kilometer;
            }
        }

        public override double Weight
        {
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return weight;
            }
        }

        public override double Length
        {
            set
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return length;
            }
        }

        public override double Width
        {
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return width;
            }
        }

        public override double Height
        {
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return height;
            }
        }

        public override double MaxSpeed
        {
            set
            {
                if (value > 0)
                {
                    max_speed = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return max_speed;
            }
        }
        public override double MinSpeed { get { return min_speed; } }
        public override string Model { set { model = value; } get { return model; } }
        public Suv(double cost, double gasoline_per_kilometer, double weight, double length, double width, double height, double max_speed, string model, double time_to_100)
        {
            this.Cost = cost;
            this.GasolinePerKilometer = gasoline_per_kilometer;
            this.Weight = weight;
            this.Length = length;
            this.Width = width;
            this.Height = height;
            this.MaxSpeed = max_speed;
            this.Model = model;
            this.TimeTo100 = time_to_100;
        }
        public override void Move()
        {
            Console.WriteLine("Едет машина с маркой Suv с моделью {0}", model);
        }
        public override void Stop()
        {
            Console.WriteLine("Останавливается машина с маркой Suv с моделью {0}", model);
        }
        public override void OverclockingTo100()
        {
            Console.WriteLine("Машина с маркой Suv разгоняется до сотки за {0} секунд", time_to_100);
        }
    }
    class Coupe : Car
    {
        private string mark = "Coupe";
        public override string Mark { get { return mark; } }
        public override double TimeTo100 // свойство для записи
        {
            set
            {
                if (value > 0)
                {
                    time_to_100 = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return time_to_100;
            }
        }
        public override double Cost
        {
            set
            {
                if (value > 0)
                {
                    cost = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return cost;
            }
        }

        public override double GasolinePerKilometer
        {
            set
            {
                if (value > 0)
                {
                    gasoline_per_kilometer = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return gasoline_per_kilometer;
            }
        }

        public override double Weight
        {
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return weight;
            }
        }

        public override double Length
        {
            set
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return length;
            }
        }

        public override double Width
        {
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return width;
            }
        }

        public override double Height
        {
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return height;
            }
        }

        public override double MaxSpeed
        {
            set
            {
                if (value > 0)
                {
                    max_speed = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return max_speed;
            }
        }
        public override double MinSpeed { get { return min_speed; } }
        public override string Model { set { model = value; } get { return model; } }
        public Coupe(double cost, double gasoline_per_kilometer, double weight, double length, double width, double height, double max_speed, string model, double time_to_100)
        {
            this.Cost = cost;
            this.GasolinePerKilometer = gasoline_per_kilometer;
            this.Weight = weight;
            this.Length = length;
            this.Width = width;
            this.Height = height;
            this.MaxSpeed = max_speed;
            this.Model = model;
            this.TimeTo100 = time_to_100;
        }
        public override void Move()
        {
            Console.WriteLine("Едет машина с маркой Coupe с моделью {0}", model);
        }
        public override void Stop()
        {
            Console.WriteLine("Останавливается машина с маркой Coupe с моделью {0}", model);
        }
        public override void OverclockingTo100()
        {
            Console.WriteLine("Машина с маркой Coupe разгоняется до сотки за {0} секунд", time_to_100);
        }
    }

    class MyCollection : IEnumerable, IEnumerator
    {
        private int count = 15;
        private int position = -1;
        private int startIndex = 0;
        private double costAutoPark = 0;
        private const int desiredSpeedMin = 0;
        private int desiredSpeedMax = 0;
        private List<Car> taksPark;
        public MyCollection(int desiredSpeedMax)
        {
            taksPark = new List<Car>(count);
            for (int i = 0; i < count; i++)
            {
                taksPark.Add(null);
            }
            this.desiredSpeedMax = desiredSpeedMax;
        }
        public MyCollection(Car elem, int desiredSpeedMax) :
            this(desiredSpeedMax)
        {
            taksPark[startIndex] = elem;
            startIndex += 1;
        }
        public MyCollection(Car[] array, int desiredSpeedMax) :
            this(desiredSpeedMax)
        {
            if (array.Length < taksPark.Count)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    taksPark[i] = array[i];
                    startIndex += 1;
                }
            }
            else
            {
                int temp = 0;
                bool flag = true;
                while (flag)
                {
                    temp += Convert.ToInt32(taksPark.Count + 0.3 * taksPark.Count);
                    if (temp < array.Length)
                        continue;
                    else
                        flag = false;
                }
                taksPark = new List<Car>(temp);
                int difference = temp - array.Length;
                //хрень что б работало, потому что изначально Лист пустой и чтоб с ним можно было работать его надо заполнить, заполняем по умолчанию
                for (int i = 0; i < temp - difference; i++)
                {
                    taksPark.Add(null);
                }
                for (int i = 0; i < array.Length; i++)
                {
                    taksPark[i] = array[i];
                    startIndex += 1;
                }
            }
        }
        //индексатор на всякий случай(это в шарпе есть такая тема, что можно к коллекции как к массиву обращаться)
        public Car this[int index]
        {
            set
            {
                if (startIndex > 0)
                {
                    if (index >= startIndex && index < taksPark.Count)
                    {
                        taksPark[index] = value;
                    }
                    else
                    {
                        throw new IndexOutOfRangeException("Индекс вне диапазона");
                    }
                }
                else
                {
                    if (index >= 0 && index < taksPark.Count)
                    {
                        taksPark[index] = value;
                    }
                    else
                    {
                        throw new IndexOutOfRangeException("Индекс вне диапазона");
                    }
                }
            }
            get
            {
                if (index >= 0 && index < taksPark.Count)
                {
                    return taksPark[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Индекс вне диапазона");
                }
            }
        }
        public void SortByGasolinePerKilometr()
        {
            taksPark.Sort();
        }

        public double GetCost
        {
            get
            {
                for (int i = 0; i < taksPark.Count; i++)
                {
                    costAutoPark += taksPark[i].Cost;
                }
                return costAutoPark;
            }
        }
        //получить коллекцию машин, у которых нужная скорость (desiredSpeed)
        public List<Car> GetDesiredCars()
        {
            List<Car> help = new List<Car>();
            foreach (Car car in taksPark)
            {
                if (car.MaxSpeed <= desiredSpeedMax)
                {
                    help.Add(car);
                }
            }
            return help;
        }
        //реализация интерфейсов что б можно было форычем проходиться по коллекции
        bool IEnumerator.MoveNext()
        {
            if (position < taksPark.Count - 1)
            {
                position++;
                return true;
            }
            else
            {
                IEnumerator help = this;
                help.Reset();
                return false;
            }
        }
        void IEnumerator.Reset()
        {
            position = -1;
        }
        object IEnumerator.Current
        {
            get { return taksPark[position]; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Audi[] allroadAudi = new Audi[7]; // массив марки Ауди модели "Allroad"
            for (int i = 0; i < allroadAudi.Length; i++)
            {
                allroadAudi[i] = new Audi(1000, 20, 40, 4.3, 1.5, 1.9, 130, "Allroad", 7.5);
            }

            Audi[] eTronAudi = new Audi[3];// массив марки Ауди модели "e-tron"
            for (int i = 0; i < eTronAudi.Length; i++)
            {
                eTronAudi[i] = new Audi(2350, 34, 37.8, 4.6, 1.8, 2, 160, "e-tron", 5.4);
            }

            Sedan[] A1Sedan = new Sedan[8]; // массив марки Седан модели "А1"
            for (int i = 0; i < A1Sedan.Length; i++)
            {
                A1Sedan[i] = new Sedan(3120, 43.8, 44.1, 5.1, 1.9, 2.5, 210, "A1", 4.2);
            }

            Suv[] Q1Suv = new Suv[5]; //массив марки Сув модели "Q1"
            for (int i = 0; i < Q1Suv.Length; i++)
            {
                Q1Suv[i] = new Suv(3400, 35.8, 39.7, 5, 3, 4, 250, "Q1", 8.4);
            }

            Coupe[] T1Coupe = new Coupe[4]; // массив марки Коуп модели "T1"
            for (int i = 0; i < T1Coupe.Length; i++)
            {
                T1Coupe[i] = new Coupe(4327, 54.6, 54, 6, 3.4, 2.3, 180, "T1", 7.8);
            }

            //Этот способ мне не нравится, но я другого не придумал как их всех заапкастить к базовому классу и добавить всех в один массив
            //Ну там скорее не апкаст, а даункст получился, потому что когда добавляешь в ArrayList, то оно заапкастилось к Обджекту, а потом надо даункастить в Car
            //Ну то есть получилось так, что сначала заапкастил к обджекту, а потом даункаст к Car, но в итоге это можно назвать апкаст 
            ArrayList helpList = new ArrayList();
            helpList.AddRange(allroadAudi);
            helpList.AddRange(eTronAudi);
            helpList.AddRange(A1Sedan);
            helpList.AddRange(Q1Suv);
            helpList.AddRange(T1Coupe);

            //Апкаст(а если точнее даункаст)
            Car[] taksPark = new Car[helpList.Count];
            for (int i = 0; i < helpList.Count; i++)
            {
                taksPark[i] = (Car)helpList[i];
            }

            Console.WriteLine("Вам диапазон надо ввести для скорости, минимальное и максимальное значение скорости:");

            int maxValue = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine("Введите максимальное значение:");
                    maxValue = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Сложно ввести число?");
                    continue;
                }
            }
            double costTaks = 0;
            MyCollection myCollection = new MyCollection(taksPark, maxValue);

            costTaks = myCollection.GetCost;
            Console.WriteLine("cost = {0}", costTaks);

            List<Car> desiredCars = myCollection.GetDesiredCars();
            foreach (Car thisCar in desiredCars)
            {
                Console.WriteLine("model - {0}, mark - {1}, maxSpeed - {2}", thisCar.Model, thisCar.Mark, thisCar.MaxSpeed);
            }

            myCollection.SortByGasolinePerKilometr();
            Console.WriteLine("Сортировка по бензину, не стал заморачиваться над красотой вывода");
            foreach (Car thisCar in myCollection)
            {
                Console.WriteLine("model - {0}, mark - {1}, gasoline per kilometr - {2}", thisCar.Model, thisCar.Mark, thisCar.GasolinePerKilometer);
            }

            Console.ReadKey();
        }
    }
}

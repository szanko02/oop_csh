class Comparer : IComparer<Human>
    {
        public int Compare(Human obj1, Human obj2)
        {
            String first = obj1.LastName;
            String second = obj2.LastName;

            return String.Compare(first, second);
        }
    }
    
class Human : IComparable
    {
        private String lastName;
        private int yearOfBirth;
        private String status;

        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public Human(String newLName, int newYear, String newStatus)
        {
            lastName = newLName;
            yearOfBirth = newYear;
            status = newStatus;
        }
        public Human()
        {
            lastName = "not defined";
            yearOfBirth = 0;
            status = "not defined";
        }

        public virtual int Info()
        {
            Console.WriteLine($"last name: {LastName}");
            Console.WriteLine($"year of birth: {yearOfBirth}");
            return 0;
        }

        public void showParametrs()
        {
            Console.WriteLine($"last name: {lastName}");
            this.Info();
            Console.WriteLine($"status: {status}");
        }

        public int CompareTo(object obj)
        {
            if (obj is Human human)
            {
                return yearOfBirth.CompareTo(human.yearOfBirth);
            }
            else if (obj is null)
            {
                throw new ArgumentNullException("Cannot compare to a null value");
            }
            else
            {
                throw new ArithmeticException("Cannot compare to a value with a mismatching type");
            }
        }
    }

class Student : Human
    {
        private int mathScore;
        private int physScore;
        private int hystScore;

        public Student(int setMath, int setPhys, int setHyust)
        {
            mathScore = setMath;
            physScore = setPhys;
            hystScore = setHyust;
        }

        public float averageScore()
        {
            return (mathScore + physScore + hystScore) / 3;
        }

        public override int Info()
        {
            if (mathScore > physScore && mathScore > hystScore)
                return mathScore;
            else if (physScore > hystScore)
                return physScore;
            else
                return hystScore;
        }
    }
    class Programm
    {
        static void Main(string[] args)
        {
            Human pers1 = new Human("Petya", 2002, "Student");
            Human pers2 = new Human("Vasya", 2002, "Student");
            Human pers3 = new Human("Kolya", 1997, "Teacher");

            Comparer comp = new Comparer();
            Human[] arr = new[] {pers1, pers2, pers3}; 

           
            for(int j = 0; j < arr.Length - 1; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    Human tempPers;
                    if (arr[i].CompareTo(arr[i + 1]) >= 0)
                    {
                       tempPers = arr[i];
                       arr[i] = arr[i + 1];
                       arr[i + 1] = tempPers;
                     }
                }
            }

           
            for (int j = 0; j < arr.Length - 1; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    Human tempPers;
                    if (comp.Compare(arr[i], arr[i +1]) >= 0)
                    {
                        tempPers = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = tempPers;
                    }
                }
            }

            
            foreach (Human i in arr)
            {
                i.Info();
            }

            Console.Read();
        }
    }

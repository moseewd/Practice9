using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice9
{
    class Program
    {
        public static int ReadNatural()
        //ввод числа для красивых лаб
        {
            bool check = false;
            int intNum=0;
            do
            {
                // Попытка перевести строку в число
                check = Int32.TryParse(Console.ReadLine(), out intNum);
                // Если попытка неудачная:
                if (!(check)|| (intNum < 0))
                    Console.WriteLine("Некорректный ввод. Попробуйте ещё раз");
            } while (!(check)||(intNum<0));
            // Если попытка удачная:
            return intNum;
        }
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            CircleList<int> circleList = new CircleList<int>();
            Console.WriteLine("Введите количество элементов которые необходимо добавить в список");
            int n = ReadNatural();
            for (int i = 0; i < n; i++)
            {
                circleList.Add(rnd.Next(-100, 101));
            }
            int sumplus=0;
            int summinus=0;

            Console.WriteLine("Текущий список:");
            Node<int> point = circleList.GetHead();
            for (int i = 0; i < circleList.Count; i++)
            {
                Console.Write( point.Data + " ");
                if (point.Data > 0)
                    sumplus += point.Data;
                else
                    summinus += point.Data;

                point = point.Next;
            }

            Console.WriteLine("Сумма всех положительных элементов={0}", sumplus);
            Console.WriteLine("Сумма всех отрицательных элементов={0}", summinus);
        }
    }
}
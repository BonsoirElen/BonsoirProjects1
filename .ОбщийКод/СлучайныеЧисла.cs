using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace НашиПомощники
{
    public class СлучайныеЧисла
    {
        private static Random Генератор = new Random();

        public static int Следующее (int Минимум, int Максимум)
        {
            return Генератор.Next(Минимум, Максимум + 1);
        }
    }
}

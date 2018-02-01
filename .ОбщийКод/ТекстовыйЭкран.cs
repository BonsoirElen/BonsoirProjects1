using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace НашиПомощники
{
    //   Enumeration = Перечисление
    public enum ЦветЭкрана
    {
        ОбычныйТекст    = 7,
        ОбычныйФон      = 0,

        Черный          = 0,
        ТемноСиний      = 1,
        ТемноЗеленый    = 2,
        ТемноБирюзовый  = 3,
        ТемноКрасный    = 4,
        ТемныйФуксия    = 5,
        ТемноЖелтый     = 6,
        Серый           = 7,
        ТемноСерый      = 8,
        Синий           = 9,
        Зеленый         = 10,
        Бирюзовый       = 11,
        Красный         = 12,
        Фуксия          = 13,
        Желтый          = 14,
        Белый           = 15
    }

    public class ТекстовыйЭкран
    {
        public static ЦветЭкрана ЦветФона
        {
            get { return (ЦветЭкрана) Console.BackgroundColor; }
            set { Console.BackgroundColor = (ConsoleColor) value; }
        }

        public static ЦветЭкрана ЦветТекста
        {
            get { return (ЦветЭкрана) Console.ForegroundColor; }
            set { Console.ForegroundColor = (ConsoleColor) value; }
        }

        public static void Очистить ()
        {
            Console.Clear();
        }

        public static void Вывод (int Число)
        {
            Console.Write(Число);
        }

        public static void Вывод (string СтрокаТекста)
        {
            Console.Write(СтрокаТекста);
        }

        public static void ВыводСтроки (int Число)
        {
            Console.WriteLine(Число);
        }

        public static void ВыводСтроки (string СтрокаТекста)
        {
            Console.WriteLine(СтрокаТекста);
        }

        public static string ЗапросСтроки ()
        {
            return Console.ReadLine();
        }

        public static int ЗапросЧисла ()
        {
        ПовторВвода:

            string ВведеннаяСтрока = Console.ReadLine();

            if (int.TryParse(ВведеннаяСтрока, out int Число))
                return Число;
            else
            {
                ТекстовыйЭкран.ЦветТекста = ЦветЭкрана.Красный;
                Вывод("Ошибка");
                ТекстовыйЭкран.ЦветТекста = ЦветЭкрана.ОбычныйТекст;
                ВыводСтроки(" Пожалуйста, повтори ввод:");
                goto ПовторВвода;
            }
        }

        public static void Пауза ()
        {
            ТекстовыйЭкран.ЦветТекста = ЦветЭкрана.ТемноБирюзовый;
            Вывод("Пауза");
            ТекстовыйЭкран.ЦветТекста = ЦветЭкрана.ОбычныйТекст;
            ВыводСтроки(" Нажмите любую клавишу для продолжения");
            Console.ReadKey();
        }
    }
}

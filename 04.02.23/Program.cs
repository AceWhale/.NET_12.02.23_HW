
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._02._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Задача 8
            Console.Write("Введите текст: ");
            string A = Console.ReadLine();
            Console.WriteLine(A);
            Console.Write("Введите позицию символа, который хотите удалить: ");
            int a_delete = Convert.ToInt32(Console.ReadLine());
            A = A.Remove(a_delete - 1, 1);
            Console.WriteLine("Результат: " + A);
            #endregion

            #region Задача 9
            Console.Write("\nВведите символ, который хотите удалить: ");
            string a_char_delete = Console.ReadLine();
            while (true)
            {
                if (A.IndexOf(a_char_delete) == -1)
                    break;
                else
                {
                    int index = A.IndexOf(a_char_delete);
                    A = A.Remove(index, 1);
                }
            }
            Console.WriteLine("Результат: " + A);
            #endregion

            #region Задача 10
            Console.Write("\nВведите символ который хотите вставить: ");
            string a_insert = Console.ReadLine();
            Console.Write("\nВведите позицию, куда хотите вставить: ");
            int a_index_insert = Convert.ToInt32(Console.ReadLine());
            A = A.Insert(a_index_insert - 1, a_insert);
            Console.WriteLine("Результат: " + A);
            #endregion

            #region Задача 11
            Console.Write("Введите текст: ");
            string B = Console.ReadLine();
            bool check = true;
            for (int i = 0; i < B.Length / 2; i++)
            {
                if (B[i] == B[B.Length - 1 - i])
                    continue;
                else
                {
                    check = false;
                    break;
                }
            }
            if (check)
                Console.WriteLine("Слово является палиндромом");
            else
                Console.WriteLine("Слово не является палиндромом");
            #endregion

            #region Задача 12
            Console.Write("Введите текст: ");
            string C = Console.ReadLine();
            string[] C_count = C.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Кол-во слов = {0}", C_count.Length);
            #endregion

            #region Задача 13
            Console.Write("Введите текст: ");
            string D = Console.ReadLine();
            Console.Write("Введите текст, который ищете: ");
            string search = Console.ReadLine();
            Console.Write("Введите текст, который хотите вставить: ");
            string put = Console.ReadLine();
            if (D.IndexOf(search) != -1)
                D = D.Replace(search, put);
            else
                Console.WriteLine("Введите текст, который ищете нет");
            Console.WriteLine("Результат: {0}", D);
            #endregion

            #region Задача 14
            Console.Write("Введите текст: ");
            string E = Console.ReadLine();
            string[] E_rep = E.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] E_rep_buf = E.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < E_rep.Length - 1; i++)
            {
                E = E.Replace(E_rep[i], E_rep_buf[i + 1]);
                E = E.Replace(" " + E_rep[i + 1], " " + E_rep_buf[i]);
            }
            Console.WriteLine("Результат: {0}", E);
            #endregion

            #region Задача 15
            Console.Write("Введите текст: ");
            string F = Console.ReadLine();
            string[] F_rep = F.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int F_count = 0;
            for (int i = 0; i < F_rep.Length; i++)
            {
                if (F_rep[i][F_rep[i].Length - 1] == 'а' || F_rep[i][F_rep[i].Length - 1] == 'о' || F_rep[i][F_rep[i].Length - 1] == 'у' ||
                    F_rep[i][F_rep[i].Length - 1] == 'е' || F_rep[i][F_rep[i].Length - 1] == 'ы' || F_rep[i][F_rep[i].Length - 1] == 'и' ||
                    F_rep[i][F_rep[i].Length - 1] == 'е' || F_rep[i][F_rep[i].Length - 1] == 'э' || F_rep[i][F_rep[i].Length - 1] == 'ю' || F_rep[i][F_rep[i].Length - 1] == 'я')
                    F_count++;
            }
            Console.WriteLine("Кол-во гласных = {0}", F_count);
            #endregion
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {   
        /// <summary>
        /// Метод, для поиска большого числа в массиве
        /// </summary>
        /// <param name="mas">Массив, в котором нужно найти максимальное число</param>
        /// <returns></returns>
        public static int MaxInt(int[] mas) //объявление метода, для нахождения макс.числа элемента в массиве
        {//0
            int max = mas[0];//1 //к переменной max присваивается первый элемент в массиве
            for (int i = 0; i < mas.Length; i++)//2 //к переменной i присваивается начальное значение =0,
            {//3
                if (max < mas[i])//4
                    max = mas[i];//5
            }//6
            return max;//7
        }//8
    }
}

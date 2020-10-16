using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lb_2
{
    public class Class1
    {
        public static int FindMin(DataGridView table, TextBox Numbers)
        {
            //Найти минимальное среди максимальных значений элементов столбца
            //Входные значения table - массив
            //Выходные значения - минимальный элемент среди максимальных элементов столбца
            int min=2147483647,
                maxl;
            for (int i = 0; i < table.ColumnCount; i++)
            {
                maxl = Convert.ToInt32(table[i, 0].Value);
                for (int j = 1; j < table.RowCount; j++)
                {
                    if (maxl < Convert.ToInt32(table[i, j].Value))
                        maxl = Convert.ToInt32(table[i, j].Value);
                }
                Numbers.Text += maxl.ToString() + " " ;
                if (maxl < min) min = maxl;
            }
            return min;
        }
    }
}

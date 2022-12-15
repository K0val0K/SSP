using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSP3_PAIN.Helpers{
    public static class GetColorHelper
    {
        public static Brush GetColor(string name)
        {
            Brush temp = Brushes.Gray;
            if (name == "Красный") temp = Brushes.Red;
            if (name == "Чёрный") temp = Brushes.Black;
            if (name == "Синий") temp = Brushes.Blue;
            if (name == "Жёлтый") temp = Brushes.Yellow;
            if (name == "Зелёный") temp = Brushes.Green;
            if (name == "Cерый") temp = Brushes.Gray;
            return temp;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LogbookWood.Data.Models
{
    public enum TreeCategory
    {
        Едра = 1,
        Средна = 2,
        Дребна = 3,
        Дърва = 4,
        Вършина = 5,
        [Description("Готови изделия")] ГотовиИзделия = 6,
        [Description("Изрезки и дърва преработени")] ИзрезкиДърваПреработени = 7,
        Фасонирана = 8,
    }

}

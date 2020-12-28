using System;
using System.Collections.Generic;
using System.Text;

namespace LogbookWood.Web.ViewModels.Processing
{
    public class ListProcessingOutViewModel
    {
        public string NumberProcessing { get; set; }

        public DateTime Date { get; set; }

        public string Wood { get; set; }

        public string Category { get; set; }

        public double TotalVolume { get; set; }
    }
}

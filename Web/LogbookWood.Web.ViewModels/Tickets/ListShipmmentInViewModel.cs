namespace LogbookWood.Web.ViewModels.Tickets
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ListShipmmentInViewModel
    {
        public string NumberTicket { get; set; }

        public DateTime Date { get; set; }

        public string Comment { get; set; }

        public string Wood { get; set; }

        public string Category { get; set; }

        public double TotalVolume { get; set; }
    }
}

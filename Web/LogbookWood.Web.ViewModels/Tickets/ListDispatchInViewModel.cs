﻿namespace LogbookWood.Web.ViewModels.Tickets
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class ListDispatchInViewModel
    {
        public string NumberTicket { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public string UserCompany { get; set; }

        public string ClientDescription { get; set; }

        public string Comment { get; set; }
    }
}

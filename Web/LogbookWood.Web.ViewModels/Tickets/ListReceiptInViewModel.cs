using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LogbookWood.Web.ViewModels.Tickets
{
    public class ListReceiptInViewModel
    {
        public string NumberTicket { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public string UserCompany { get; set; }

        public string SenderName { get; set; }

        public string Comment { get; set; }
    }
}

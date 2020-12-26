namespace LogbookWood.Services.Data.Models
{
    using System.Collections.Generic;
    using System.Linq;

    using LogbookWood.Data.Common.Repositories;
    using LogbookWood.Data.Models;
    using LogbookWood.Web.ViewModels.Reports;

    public class ReportsService : IReportsService
    {
        private readonly IRepository<Ticket> ticketRepository;

        public ReportsService(IRepository<Ticket> ticketRepository)
        {
            this.ticketRepository = ticketRepository;
        }

        public virtual IEnumerable<TicketReportInViewModel> CreateReport(string userId)
        {
            List<TicketReportInViewModel> woodAndCategory = this.AddWoodAndCategory();

            List<TicketReportInViewModel> ticketIn = this.ticketRepository.All().Where(x => x.UserId == userId)
                .Select(x => new TicketReportInViewModel
                {
                    Wood = x.Wood,
                    Category = x.Category,
                    TotalVolume = x.TotalVolume,
                }).ToList();

            foreach (TicketReportInViewModel ticket in ticketIn)
            {
                foreach (TicketReportInViewModel list in woodAndCategory)
                {
                    if (ticket.Wood == list.Wood && ticket.Category == list.Category)
                    {
                        list.TotalVolume += ticket.TotalVolume;
                    }
                }
            }

            return woodAndCategory.Where(x => x.TotalVolume != 0).ToList();
        }

        public List<TicketReportInViewModel> AddWoodAndCategory()
        {
            List<TicketReportInViewModel> lists = new List<TicketReportInViewModel>();

            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Бук", Category = "Едра" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Бук", Category = "Средна" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Бук", Category = "Дребна" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Бук", Category = "Дърва" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Бук", Category = "Вършина" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Бук", Category = "Готови изделия" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Бук", Category = "Изрезки и дърва преработени" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Бук", Category = "Фасонирана" });

            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Дъб", Category = "Едра" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Дъб", Category = "Средна" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Дъб", Category = "Дребна" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Дъб", Category = "Дърва" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Дъб", Category = "Вършина" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Дъб", Category = "Готови изделия" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Дъб", Category = "Изрезки и дърва преработени" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Дъб", Category = "Фасонирана" });

            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Цер", Category = "Едра" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Цер", Category = "Средна" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Цер", Category = "Дребна" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Цер", Category = "Дърва" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Цер", Category = "Вършина" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Цер", Category = "Готови изделия" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Цер", Category = "Изрезки и дърва преработени" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Цер", Category = "Фасонирана" });

            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Акация", Category = "Едра" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Акация", Category = "Средна" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Акация", Category = "Дребна" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Акация", Category = "Дърва" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Акация", Category = "Вършина" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Акация", Category = "Готови изделия" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Акация", Category = "Изрезки и дърва преработени" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Акация", Category = "Фасонирана" });

            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Габър", Category = "Едра" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Габър", Category = "Средна" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Габър", Category = "Дребна" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Габър", Category = "Дърва" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Габър", Category = "Вършина" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Габър", Category = "Готови изделия" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Габър", Category = "Изрезки и дърва преработени" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Габър", Category = "Фасонирана" });

            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Смърч", Category = "Едра" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Смърч", Category = "Средна" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Смърч", Category = "Дребна" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Смърч", Category = "Дърва" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Смърч", Category = "Вършина" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Смърч", Category = "Готови изделия" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Смърч", Category = "Изрезки и дърва преработени" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Смърч", Category = "Фасонирана" });

            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Бял бор", Category = "Едра" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Бял бор", Category = "Средна" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Бял бор", Category = "Дребна" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Бял бор", Category = "Дърва" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Бял бор", Category = "Вършина" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Бял бор", Category = "Готови изделия" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Бял бор", Category = "Изрезки и дърва преработени" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Бял бор", Category = "Фасонирана" });

            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Ела", Category = "Едра" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Ела", Category = "Средна" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Ела", Category = "Дребна" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Ела", Category = "Дърва" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Ела", Category = "Вършина" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Ела", Category = "Готови изделия" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Ела", Category = "Изрезки и дърва преработени" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Ела", Category = "Фасонирана" });

            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Черен бор", Category = "Едра" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Черен бор", Category = "Средна" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Черен бор", Category = "Дребна" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Черен бор", Category = "Дърва" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Черен бор", Category = "Вършина" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Черен бор", Category = "Готови изделия" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Черен бор", Category = "Изрезки и дърва преработени" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Черен бор", Category = "Фасонирана" });

            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Кедър", Category = "Едра" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Кедър", Category = "Средна" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Кедър", Category = "Дребна" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Кедър", Category = "Дърва" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Кедър", Category = "Вършина" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Кедър", Category = "Готови изделия" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Кедър", Category = "Изрезки и дърва преработени" });
            lists.Add(new TicketReportInViewModel { TotalVolume = 0, Wood = "Кедър", Category = "Фасонирана" });

            return lists;
        }
    }
}

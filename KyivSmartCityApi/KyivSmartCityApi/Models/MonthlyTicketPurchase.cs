using System;
using System.Collections.Generic;
using System.Text;
namespace KyivSmartCityApi.Models
{
    public class MonthlyTicketPurchase
    {
        public byte AvailableMonth { get; set; }
        public bool HalfAMonth { get; set; }
    }
}
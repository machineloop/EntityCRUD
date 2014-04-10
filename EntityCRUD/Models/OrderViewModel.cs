using EntityCRUD.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityCRUD.Models
{
    public class OrderViewModel
    {
        public List<Order> VMOrders { get; set; }
        public Order VMOrder { get; set; }
    }
}
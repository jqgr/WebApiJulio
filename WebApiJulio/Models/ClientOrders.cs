using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApiJulio.Models
{

    public class ClientOrders
    {
        [Key]
        public int orderid { get; set; }
        public string requireddate { get; set; }
        public string shippeddate { get; set; }
        public string shipname { get; set; }
        public string shipaddress { get; set; }
        public string shipcity { get; set; }
    }
}

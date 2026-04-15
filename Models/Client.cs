using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1291763.Models
{
    public class Client : BaseEntry
    {
        public string FullName { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public int BankId { get; set; }
    }
}



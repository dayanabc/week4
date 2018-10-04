using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public class DeskQuote
    {
        public int DesquoteId { get; set; }

        public DateTime QuoteDate { get; set; }

        public string CustomerName { get; set; }

        public Desk Desk { get; set; }

    }
}

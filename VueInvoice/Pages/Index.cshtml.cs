using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VueInvoice.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Invoice> Invoices { get; private set; }

        public void OnGet()
        {
            Invoices = new List<Invoice>
            {
                new Invoice
                {
                    Number = "111",
                    Items = new List<LineItem>
                    {
                        new LineItem
                        {
                            Name = "Reese Cup",
                            Quantity = 24,
                            UnitPrice = 1.29M
                        },
                        new LineItem
                        {
                            Name = "Snickers",
                            Quantity = 48,
                            UnitPrice = 1.69M
                        },
                        new LineItem
                        {
                            Name = "Whoppers",
                            Quantity = 96,
                            UnitPrice = .89M
                        },
                        new LineItem
                        {
                            Name = "Milk Duds",
                            Quantity = 64,
                            UnitPrice = .99M
                        }
                    }
                }
            };
        }
    }

    public class Invoice
    {
        public string Number { get; set; }
        public IEnumerable<LineItem> Items { get; set; }
        public decimal Amount => Items.Select(i => i.TotalPrice).Sum();
    }

    public class LineItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice => Quantity * UnitPrice;
    }
}

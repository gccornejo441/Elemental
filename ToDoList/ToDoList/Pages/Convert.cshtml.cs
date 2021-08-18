using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ToDoList.Pages
{
    public class ConvertModel : PageModel
    {
        public string Values { get; set; }

        public void OnGet( string currencyIn, string currencyOut, int qty )
        {
            Values = $@"CurrencyIn: {currencyIn} CurrencyOut: {currencyOut} Quantity: {qty}";
        }

        public void OnPost( string currencyIn, string currencyOut, int qty)
        {
            Values = $@"CurrencyIn: {currencyIn} CurrencyOut: {currencyOut} Quantity: {qty}";
        }
    }
}

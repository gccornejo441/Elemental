using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopeTestingDotNET5
{
    class Language
    {
        public string Value { get; }
        public string Item { get; }
        public Language(string value, string item)
        {
            Value = value;
            Item = item;
        }
    }
}

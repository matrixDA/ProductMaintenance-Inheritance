using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMaintenance
{
    public class Book : Product
    {
        public string Author { get; set; } = "";

        public Book()
        {
        }
        public Book(string code, string description, decimal price, string author) : base(code, description, price) => Author = author;

        public override string GetDisplayText(string sep) =>
            $"{base.GetDisplayText(sep)}, {sep}{Author}";

    }
}

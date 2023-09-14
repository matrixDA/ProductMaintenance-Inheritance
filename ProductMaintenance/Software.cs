using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMaintenance
{
    public class Software : Product
    {
        public Software()
        {
        }

        public string Version { get; set; } = "";

        public Software(string code, string description, decimal price, string version) : base(code, description, price) => Version = Version;

        public override string GetDisplayText(string sep) =>
            $"{base.GetDisplayText(sep)}, {sep}{Version}";
    }
}

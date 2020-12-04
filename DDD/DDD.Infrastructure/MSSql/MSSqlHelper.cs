using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infrastructure.MSSql
{
    internal class MSSqlHelper
    {
        internal const string ConnectionString = @"server=(local);Initial Catalog = DDD;Integrated Security=false;
                                                      User ID=sa;Password=";
    }
}

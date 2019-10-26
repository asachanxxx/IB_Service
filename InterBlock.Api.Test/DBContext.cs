using InterBlock.BI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterBlock.Api.Common
{
    public class MainDBContext:DbContext
    {
        public MainDBContext()
            : base("SysConSQL")
        {

        }

        public DbSet<KeyVal> KeyVal { get; set; }
        public DbSet<Accounts> Accounts { get; set; }
    }
}

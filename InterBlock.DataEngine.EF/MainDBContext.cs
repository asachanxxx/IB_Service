using InterBlock.BI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterBlock.DataEngine.EF
{
    public class MainDBContext:DbContext
    {
        public MainDBContext():base("SysConSQL")
        {

        }

        public DbSet<Accounts> Accounts { get; set; }
    }
}

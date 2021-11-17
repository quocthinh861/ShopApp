using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Data.Data
{
    public class EShopDBContext : DbContext
    {
        public EShopDBContext(DbContextOptions options) : base(options)
        {
        }

        protected override void ModelCreating(ModelBuilder modelBuilder)
        {

        }


    }
}

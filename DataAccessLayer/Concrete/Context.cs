using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    //context classı: veri tabanı yapılandırması bağlantı stringini tutar
    //veri tabanında bulunacak tabloların isimlerini tutar
    //Context:DbContext yazmamızın sebebi db setleri kullanabilmektir
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=serveradresigelecekburaya;database=CoreProjeDB;integrated security=true");
        }

    }
}

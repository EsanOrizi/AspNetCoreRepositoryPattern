using MyMDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMDB.Data.EFCore
{
    public class EfCoreStarRepository : EfCoreRepository<Star, MyMDBContext>
    {
        public EfCoreStarRepository(MyMDBContext context) : base(context)
        {

        }
    }
}

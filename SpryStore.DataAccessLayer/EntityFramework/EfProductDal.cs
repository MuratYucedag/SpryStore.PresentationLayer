using SpryStore.DataAccessLayer.Abstract;
using SpryStore.DataAccessLayer.Repositories;
using SpryStore.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryStore.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
    }
}

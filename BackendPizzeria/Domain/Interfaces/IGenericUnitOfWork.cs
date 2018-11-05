using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendPizzeria.Domain
{
    public interface IGenericUnitOfWork<T> : IUnitOfWork where T:class
    {
        IDbSet<T> Pizzas { get; }
    }


}

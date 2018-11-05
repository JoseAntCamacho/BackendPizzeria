using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendPizzeria.Domain
{
    public interface IPizzaContext:IGenericUnitOfWork<Pizza>
    {
    }
}

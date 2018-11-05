using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendPizzeria.Domain
{
    public interface IPizzaRepository
    {
        IEnumerable<Pizza> GetAll();
        Pizza GetById(int id);
        void UpdateCommentary(int idPizza, Commentary commentary);
        void Create(Pizza pizza);
    }
}

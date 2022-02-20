using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gb.TimeSheets.Entities
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        IEnumerable<T> GetByName(string firstName);

        IEnumerable<T> GetFromTo(int skip, int take);

        T GetById(int id);

        void Create(T person);

        void Update(T person);

        void Delete(int id);
    }
}

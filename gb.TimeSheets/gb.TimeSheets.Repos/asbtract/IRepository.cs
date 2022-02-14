using System.Collections.Generic;

namespace gb.TimeSheets.Repos
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

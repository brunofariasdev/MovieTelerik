using MovieTelerik.Models;

namespace MovieTelerik.Repository
{
    public interface IRepository<T> where T : EntityBase
    {
        void Create(T model);
        void Update(T model);
        void Delete(int id);
        IEnumerable<T> GetAll();
        T GetById(int Id);
    }
}

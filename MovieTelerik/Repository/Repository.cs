using MovieTelerik.Data;
using MovieTelerik.Models;

namespace MovieTelerik.Repository
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        private DataContext _context; 
        

        public Repository(DataContext context)
        {
            _context = context;
        }
        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = GetById(id);

            if(entity == null)
            {
                return;
            }

            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().FirstOrDefault(e => e.Id == id);
        }

        public void Update(T model)
        {
            if(model == null)
            {
                return;
            }
            _context.Set<T>().Update(model);
            _context.SaveChanges();
        }
    }
}

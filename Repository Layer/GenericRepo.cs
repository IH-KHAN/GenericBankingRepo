using _1291763.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1291763.Repository_Layer
{
    public class GenericRepo<T> : IRepo<T> where T : BaseEntry
    {
        private readonly IList<T> data = new List<T>();

        public void Add(T entity) => data.Add(entity);

        public void AddRange(IEnumerable<T> entities)
        {
            foreach (var item in entities)
                data.Add(item);
        }

        public void Delete(int id)
        {
            var entity = data.FirstOrDefault(x => x.Id == id);
            if (entity != null) data.Remove(entity);
        }

        public T Get(int id) => data.FirstOrDefault(x => x.Id == id);

        public List<T> GetAll() => data.ToList();

        public void Update(T entity)
        {
            int i = data.IndexOf(entity);
            data.RemoveAt(i);
            data.Add(entity);
        }
    }
}



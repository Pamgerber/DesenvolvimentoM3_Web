using Data.Context;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositorys
{
    class BaseRepository<T> where T : BaseModel
    {
        public void Create(T model)
        {
            using (var context = new LabContext())
            {
                context.Set<T>().Add(model);
                context.SaveChanges();
            }
        }
        public List<T> Read()
        {
            List<T> lista = new List<T>();
            using (var context = new LabContext())
            {
                lista = context.Set<T>().ToList();
            }
            return lista;
        }
        public T Read(int id)
        {
            T model = Activator.CreateInstance<T>();
            using (var context = new LabContext())
            {
                model = context.Set<T>().Find(id);
            }
            return model;
        }
        public void Update(T model)
        {
            using (var context = new LabContext())
            {
                context.Entry<T>(model).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            using (var context = new LabContext())
            {
                context.Entry<T>(Read(id)).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}

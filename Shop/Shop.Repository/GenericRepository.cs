using Microsoft.EntityFrameworkCore;
using Shop.IRepository;
using Shop.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Repository
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{
		private readonly ShopOnlineContext _context;
		private readonly DbSet<T> _entities;
		public GenericRepository()
		{
			_context = new ShopOnlineContext();
			_entities = _context.Set<T>();
		}
		public GenericRepository(ShopOnlineContext context)
		{
			_context = context;
			_entities = _context.Set<T>();
		}
		public IEnumerable<T> GetAll()
		{
			return _entities.AsEnumerable();
		}
		public T GetById(int id)
		{
			return _entities.Find(id);
		}
		public int Insert(T entity)
		{
			_entities.Add(entity);
			return _context.SaveChanges();
		}
		public int Update(T entity)
		{
			_entities.Update(entity);
			return _context.SaveChanges();
		}
		public int Delete(int id)
		{
			var entity = _entities.Find(id);
			_entities.Remove(entity);
			return _context.SaveChanges();
		}
	}
}


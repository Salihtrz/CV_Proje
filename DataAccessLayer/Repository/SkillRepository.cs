using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
	public class SkillRepository : IGenericDal<Skill>
	{
		public void Delete(Skill t)
		{
			throw new NotImplementedException();
		}

        public List<Skill> GetbyFilter(Expression<Func<Skill, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Skill GetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<Skill> GetList()
		{
			throw new NotImplementedException();
		}

		public void Insert(Skill t)
		{
			throw new NotImplementedException();
		}

		public void Update(Skill t)
		{
			throw new NotImplementedException();
		}
	}
}

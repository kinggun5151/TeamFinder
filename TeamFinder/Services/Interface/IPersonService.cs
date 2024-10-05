using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamFinder.Models.Entities;


namespace TeamFinder.Services.Interface
{
    public interface IPersonService
    {
        public void Add(Person item);
        public IEnumerable<Person> GetAll();
        public Person Get(int id);
        public Person GetFirstOrDefult(System.Linq.Expressions.Expression<Func<Person, bool>> filter);
        public void Remove(Person item);
        public void RemoveRange(IEnumerable<Person> items);
        public void Update(Person obj);


    }
}

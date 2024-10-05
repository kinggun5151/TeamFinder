using TeamFinder.Data;
using TeamFinder.Models.Entities;
using TeamFinder.Services.Interface;

namespace TeamFinder.Services
{
    public class PersonService : IPersonService
    {
        private readonly ApplicationDbContext _db;

        public PersonService(ApplicationDbContext db)
        {
            _db = db;
        }

        public void Add(Person item)
        {
            _db.Person.Add(item);
            _db.SaveChanges();
        }

        public IEnumerable<Person> GetAll()
        {
            IQueryable<Person> query = _db.Person;
            foreach (Person item in query)
            {
                item.PersonalInfo = _db.Info.Find(item.PersonId);
                item.Skills=_db.Skills.Where(e=>e.PersonId==item.PersonId).ToList();
            }
            return query.ToList();
        }

        public Person Get(int id)
        {
            Person person = _db.Person.Find(id);
            person.PersonalInfo = _db.Info.Find(person.PersonId);
            person.Skills = _db.Skills.Where(e => e.PersonId == person.PersonId).ToList();
            return person ;
        }
        public Person GetFirstOrDefult(System.Linq.Expressions.Expression<Func<Person, bool>> filter)
        {
            IQueryable<Person> query = _db.Person;
            query = query.Where(filter);
            return query.FirstOrDefault();
        }

        public void Remove(Person item)
        {
            _db.Person.Remove(item);
            _db.SaveChanges();
        }

        public void RemoveRange(IEnumerable<Person> items)
        {
            _db.Person.RemoveRange(items);
            _db.SaveChanges();
        }
        public void Update(Person obj)
        {
            _db.Update(obj);
            _db.SaveChanges();
       
        }
    }
}

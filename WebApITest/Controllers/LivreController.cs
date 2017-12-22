using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApITest.Models;

namespace WebApITest.Controllers
{
    public class LivreController : ApiController
    {
        public IEnumerable<Livre> Get()
        {
            using (TestDatabaseEntities1 entities = new TestDatabaseEntities1())
            {
                return entities.Livres.ToList();
            }
        }

       /* public Livre Get(int login)
        {
            using (TestDatabaseEntities1 entities = new TestDatabaseEntities1())
            {
                return entities.Livres.FirstOrDefault(u => u.id == login);
            }
        } */

    }
}
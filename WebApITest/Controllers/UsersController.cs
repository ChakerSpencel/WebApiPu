using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApITest.Controllers
{
    public class UsersController : ApiController
    {
        public IEnumerable <User> Get ()
        {
            using (TestDatabaseEntities entities = new TestDatabaseEntities ())
            {
                return entities.Users.ToList();
            }
        }


        public User Get(string login )
        {
            using (TestDatabaseEntities entities = new TestDatabaseEntities())
            {
                return entities.Users.FirstOrDefault(u => u.login == login);
            }
        }


    }

}

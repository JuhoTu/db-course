using System;
using System.Collections.Generic;
using System.Text;
using db_task.Models;

namespace db_task.Repository
{
    interface IPersonRepository
    {
        person Create(person newPerson);
        List<person> Read();
        person ReadById(long id);
        person Update(person updatePerson);
        void Delete(person deletePerson);
    }
}

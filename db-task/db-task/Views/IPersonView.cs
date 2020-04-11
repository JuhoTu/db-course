using System;
using System.Collections.Generic;
using System.Text;
using db_task.Models;

namespace db_task.Views
{
    interface IPersonView
    {
        person Create(person newPerson);
        List<person> Read();
        person Update(person updatePerson);
        person Delete(long id);
    }
}

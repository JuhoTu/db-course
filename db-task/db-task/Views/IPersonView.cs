using System;
using System.Collections.Generic;
using System.Text;
using db_task.Models;

namespace db_task.Views
{
    interface IPersonView
    {
        void Create(person newPerson);
        void Read();
        void Update(person updatePerson);
        void Delete(long id);
    }
}

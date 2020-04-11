using System;
using System.Collections.Generic;
using System.Text;
using db_task.Models;

namespace db_task.Views
{
    interface IPersonView
    {
        void Create();
        void Read();
        void Update();
        void Delete(long id);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using db_task.Models;

namespace db_task.Views
{
    interface IPhoneView
    {
        void Create(int id);
        void Read(long id);
        void Update();
        void Delete(long id);
    }
}

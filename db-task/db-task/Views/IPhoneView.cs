using System;
using System.Collections.Generic;
using System.Text;
using db_task.Models;

namespace db_task.Views
{
    interface IPhoneView
    {
        void Create(phone newphone);
        void Read();
        void Update(phone updatephone);
        void Delete(long id);
    }
}

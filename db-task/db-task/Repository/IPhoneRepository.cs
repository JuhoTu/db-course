using System;
using System.Collections.Generic;
using System.Text;
using db_task.Models;

namespace db_task.Repository
{
    interface IPhoneRepository
    {
        phone Create(phone newphone);
        List<phone> Read();
        phone Update(phone updatephone);
        phone Delete(long id);
    }
}

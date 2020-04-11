using System;
using System.Collections.Generic;
using System.Text;
using db_task.Models;

namespace db_task.Services
{
    interface IPhoneService
    {
        phone Create(phone newphone);
        List<phone> Read(long id);
        phone ReadById(long id);
        phone Update(long id, phone updatedNum);
        phone Delete(long id);
    }
}

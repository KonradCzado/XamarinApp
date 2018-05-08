using System;
using System.Collections.Generic;
using System.Text;

namespace App3.ViewModels
{
    public interface IRepository<T>
    {
        T GetAllItems();
    }
}

using Restouran_task.Abstracrion;
using Restouran_task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restouran_task.Interfaces
{
    public interface IMenu
    {
        public void GetMenu();
        public void GetDish(string name);
    }
}

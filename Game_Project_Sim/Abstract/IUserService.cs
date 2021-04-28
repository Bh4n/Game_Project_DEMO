using Game_Project_Sim.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Project_Sim.Abstract
{
   public interface IUserService
    {
        void Add(User user);
        void Update(User user);
        void Delete(User user);
    }
}

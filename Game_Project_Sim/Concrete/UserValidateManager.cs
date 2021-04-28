using Game_Project_Sim.Abstract;
using Game_Project_Sim.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Project_Sim.Concrete
{
    class UserValidateManager : IUserValidateService
    {
        public bool Validate(User user)
        {
            return true;
        }
    }
}

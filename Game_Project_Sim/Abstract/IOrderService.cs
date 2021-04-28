using System;
using System.Collections.Generic;
using System.Text;
using Game_Project_Sim.Entities;
namespace Game_Project_Sim.Abstract
{
    public interface IOrderService
    {
        void CampWithSale(User user,Game game,Campaign campaign);
        void CampWithoutSale(User user,Game game);
    }
}
